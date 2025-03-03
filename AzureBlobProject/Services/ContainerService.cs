
using Azure.Storage.Blobs;
using System.Runtime.CompilerServices;

namespace AzureBlobProject.Services
{
    public class ContainerService : IContainerService
    {
        private readonly BlobServiceClient _blobClient;

        public ContainerService(BlobServiceClient bobClient)
        {
               _blobClient = bobClient;
        }

        public Task CreateContainer(string containerName)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContainer(string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetAllContainer()
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetAllContainerAndBlobs()
        {
            throw new NotImplementedException();
        }
    }
}
