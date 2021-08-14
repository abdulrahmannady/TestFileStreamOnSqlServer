using FileStream.EntityClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace TestFileStreamOnSqlServer.Web.Models
{
    public class FileViewModel
    {
        public IFormFile Upload { get; set; }
        public AttachmentEntity Download { get; set; }
    }
}
