using FileStream.DatabaseSpecific;
using FileStream.EntityClasses;
using FileStream.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestFileStreamOnSqlServer.Web.Models;

namespace TestFileStreamOnSqlServer.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var attachment = GetFirestAttachment();

            if (attachment is null)
            {
                return View(null);
            }

            return View(new FileViewModel { Download = attachment });
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile upload)
        {
            var attachment = new AttachmentEntity()
            {
                IsNew = true,
                OriginalFileName = upload.FileName,
                MimeType = upload.ContentType,
                File = await upload.GetBytes(),
            };

            using (var adapter = new DataAccessAdapter())
            {
                adapter.SaveEntity(attachment);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public FileResult Download()
        {
            // act like I searched for spacific file by id in DB
            var attachment = GetFirestAttachment();

            //Recreate file from DB in memory
            return File(attachment.File, attachment.MimeType, attachment.OriginalFileName);
        }

        private AttachmentEntity GetFirestAttachment()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);
                var query = from a in metaData.Attachment
                            select a;
                return query.FirstOrDefault();
            }
        }
    }



}
