using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AzureBlobPractice.Models;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AzureBlobPractice.Services
{
    public interface IAzureBlobConnectionFactory
    {
        Task<CloudBlobContainer> GetCloudBlobContainer();
    }
    public class AzureBlobConnectionFactory : IAzureBlobConnectionFactory
    {
        private readonly IConfiguration configuration;
        private CloudBlobClient blobClient;
        private CloudBlobContainer blobContainer;

        public AzureBlobConnectionFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<CloudBlobContainer> GetCloudBlobContainer()
        {
            if (blobContainer != null)
                return blobContainer;

            var blobContainerName = configuration.GetValue<string>("ContainerName").ToString();
            if (string.IsNullOrWhiteSpace(blobContainerName))
            {
                throw new ArgumentException("Configuration should contain container name.");
            }
            var _blobClient = GetClient();
            blobContainer = _blobClient.GetContainerReference(blobContainerName);
            if(await blobContainer.CreateIfNotExistsAsync())
            {
                await blobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
            }
            return blobContainer;


        }

        private CloudBlobClient GetClient()
        {
            if(blobClient != null)
            {
                return blobClient;
            }

            var storageConnectionString = configuration.GetValue<string>("StorageConnectionString").ToString();
            if(string.IsNullOrWhiteSpace(storageConnectionString))
            {
                throw new ArgumentException("Configuration should contain StorageConnectionString.");
            }
            // CloudStorageAccount storageAccount = CloudStorageAccount.Parse(storageConnectionString);
            if (!CloudStorageAccount.TryParse(storageConnectionString, out CloudStorageAccount storageAccount))
            {
                throw new Exception("Could not create storage account.");
            }
            // Create a blob client for interacting with the blob service.
            blobClient = storageAccount.CreateCloudBlobClient();
            return blobClient;
        }

    }
}
