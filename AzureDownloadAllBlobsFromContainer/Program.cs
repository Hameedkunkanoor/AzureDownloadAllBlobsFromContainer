// See https://aka.ms/new-console-template for more information
using Azure.Storage.Blobs;
Console.WriteLine("Hello, World!");
//the container name from which you want to download files from
string containerName = "your_container_name";
//get connection string from Home -> Storage account -> Access keys(Under security + networking) -> Connection string
string connectionString = "{place_your_connection_string}";

BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
var blobFiles = blobContainerClient.GetBlobs();
foreach(var file in blobFiles)
{
    BlobClient blobClient=blobContainerClient.GetBlobClient(file.Name);
    blobClient.DownloadTo(@"C:\Users\Lenovo\Downloads\Blobs\"+file.Name);
}
Console.ReadKey();
