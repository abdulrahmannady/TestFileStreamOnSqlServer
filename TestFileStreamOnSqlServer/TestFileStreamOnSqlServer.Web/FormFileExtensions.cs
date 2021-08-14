﻿using FileStream.EntityClasses;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace TestFileStreamOnSqlServer.Web
{
    public static class FormFileExtensions
    {
        public static async Task<byte[]> GetBytes(this IFormFile formFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                await formFile.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }

}
