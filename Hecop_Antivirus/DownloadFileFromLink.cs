using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Hecop_Antivirus
{
    public class DownloadFileFromLink
    {

        public int NumberOfFiles { get; private set; } = 0;

        public double Percentage { get; set; } = 0;

     
        public async Task DownloadMultiFiles(List<(string url, string savePath)> filesToDownload)
        {

            using (HttpClient httpClient = new HttpClient())
                foreach (var file in filesToDownload)
                {
                    string url = file.url;
                    using (HttpResponseMessage response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                    {
                        response.EnsureSuccessStatusCode();
                        long totalBytes = response.Content.Headers.ContentLength ?? -1;
                        Percentage += Convert.ToDouble(totalBytes);
                    }

                }

    
            using (HttpClient httpClient = new HttpClient())
                foreach (var file in filesToDownload)
                {
                    string url = file.url;
                    string savePath = file.savePath;

                    using (HttpResponseMessage response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                    {
                        response.EnsureSuccessStatusCode();

                        long totalBytes = response.Content.Headers.ContentLength ?? -1;
                        long receivedBytes = 0;

                        using (Stream contentStream = await response.Content.ReadAsStreamAsync())
                        {
                            using (FileStream fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                byte[] buffer = new byte[4096];
                                int bytesRead;
                                double percentage;

                                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                                {
                                    fileStream.Write(buffer, 0, bytesRead);
                                    receivedBytes += bytesRead;

                                    if (totalBytes > 0)
                                    {
                                        percentage = (double)receivedBytes / totalBytes * 100;
                                        Console.WriteLine($"Downloaded '{Path.GetFileName(savePath)}': {percentage:F2}%");
                                    }
                                }
                            }
                        }
                    }
                }

            Console.WriteLine("Download complete!");
        }

        public Task DownloadFiles(string[] urls, string destinationFolder)
        {
            var a = new Task((Action)(() =>
            {
                using (WebClient webClient = new WebClient())
                {
                    foreach (string url in urls)
                    {
                        try
                        {
                            Uri uri = new Uri(url);
                            string fileName = System.IO.Path.GetFileName(uri.LocalPath);
                            string destinationFilePath = System.IO.Path.Combine(destinationFolder, fileName);

                            // Tạo một yêu cầu HEAD để chỉ lấy thông tin tệp tin, không tải về toàn bộ nội dung
                            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                            request.Method = "HEAD";

                            // Nhận phản hồi từ máy chủ
                            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                            {
                                // Kiểm tra xem yêu cầu đã thành công hay không (status code 200)
                                if (response.StatusCode == HttpStatusCode.OK)
                                {
                                    // Lấy dung lượng tệp tin từ Header
                                    long fileSize = response.ContentLength;

                                    Console.WriteLine($"Downloading {fileName} ({fileSize} bytes)...");
                                    webClient.DownloadFile(url, destinationFilePath);
                                    Console.WriteLine($"Download of {fileName} completed!");
                                }
                                else
                                {
                                    Console.WriteLine($"Error: Unable to get file information for {url}. Status code: {response.StatusCode}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error while downloading {url}: {ex.Message}");
                        }
                    }
                }
            }));
            return a;
        }
    }
}
