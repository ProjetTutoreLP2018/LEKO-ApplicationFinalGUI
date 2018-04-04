using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Drive.v3.DriveService;
using File = Google.Apis.Drive.v3.Data.File;

namespace WindowsFormsApp1
{
    class GoogleDriveManager
    {

        private static string[] Scopes = { DriveService.Scope.Drive };
        private static string _applicationName = "UploadDocumentToGoogleDrive";

        private static string _folderId = "1mDdC7DtTZOG-Pb244bB_pMzE8v_LWizB";
       // private static string _fileName = "FichierTest";
       // private static string _filepath = @"C:\Users\salemi\Desktop\FichierTest.Docx";
        private static string _contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
        private static string _downloadFilePath = @"C:\Users\salemi\Desktop\FichiersTelechargeDepuisLeDrive\FichierTestTelecharge.docx";

        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Create creditential");
            UserCredential credential = GetUserCredential();

            Console.WriteLine("Get service");
            DriveService service = GetDriveService(credential);

            Console.WriteLine("Uploading File");
            var fileId = UploadFileToDrive(service, _fileName, _filepath, _contentType);

            Console.WriteLine("Download File");
            DownloadFileFromDrive(service, fileId, _downloadFilePath);

            Console.WriteLine("End");
            Console.ReadLine();
        }
        */

        public static UserCredential GetUserCredential()
        {
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string creadPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                creadPath = Path.Combine(creadPath, "driveApiCredentials", "drive-credentials.json");

                return GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "User",
                    CancellationToken.None,
                    new FileDataStore(creadPath, true)).Result;
            }

        }

        public static DriveService GetDriveService(UserCredential credential)
        {
            return new DriveService(
                new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = _applicationName
                });
        }

        public static string UploadFileToDrive(DriveService service, string fileName, string filePath)
        {
            var fileMetaData = new File();
            fileMetaData.Name = fileName;
            fileMetaData.Parents = new List<string> { _folderId };

            FilesResource.CreateMediaUpload request;

            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                request = service.Files.Create(fileMetaData, stream, _contentType);
                request.Upload();
            }

            var file = request.ResponseBody;
            return file.Id;

        }

        public static void DownloadFileFromDrive(DriveService service, string fileId, string filePath)
        {
            var request = service.Files.Get(fileId);

            using (var memoryStream = new MemoryStream())
            {
                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                            Console.WriteLine(progress.BytesDownloaded);
                            break;
                        case DownloadStatus.Completed:
                            Console.WriteLine("Download complete");
                            break;
                        case DownloadStatus.Failed:
                            Console.WriteLine("Download failed");
                            break;
                    }
                };

                request.Download(memoryStream);

                using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    fileStream.Write(memoryStream.GetBuffer(), 0, memoryStream.GetBuffer().Length);
                }


            }
        }


    }
}
