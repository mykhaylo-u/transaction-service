﻿using System.IO;
using System.Threading.Tasks;
using transaction_service.domain.Dto;

namespace transaction_service.domain.Interfaces
{
    public interface IFileUploader
    {
        public Task UploadFileAsync(FileDto file, MemoryStream memoryStream);
    }
}
