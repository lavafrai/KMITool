using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMITool
{
    internal class FileUploader
    {
        private static readonly HttpClient http = new HttpClient();
        private string path;
        private string? uploadedLink;

        public FileUploader(string path)
        {
            this.path = path;
        }

        public bool Upload()
        {
            MultipartFormDataContent formData = new MultipartFormDataContent();
            formData.Add(new StreamContent(File.Open(path, FileMode.Open)), "kmi");
            Task<HttpResponseMessage> responseTask = http.PostAsync("https://kmi.aeza.net", formData);
            try
            {
                responseTask.Wait();
            }
            catch (Exception)
            {
                return false;
            }

            if (responseTask.IsCompleted)
            {
                HttpResponseMessage responseMessage = responseTask.Result;
                uploadedLink = (new StreamReader(responseMessage.Content.ReadAsStream())).ReadToEnd();
                return true;
            }
            return false;
        }

        public string getLink()
        {
            return uploadedLink ?? "Unexpected error while uploading";
        }
    }
}
