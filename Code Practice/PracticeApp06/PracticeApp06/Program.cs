/*
 * Custom EventHandler *Done
*/

namespace PracticeApp06
{
    // Custom EventArgs class to hold additional event data
    class FileDownloadedEventArgs : EventArgs
    {
        public string FileName { get; set; }
        public long FileSize { get; set; }

        public FileDownloadedEventArgs(string fileName, long fileSize)
        {
            FileName = fileName;
            FileSize = fileSize;
        }
    }

    class DownloadManager
    {
        public event EventHandler<FileDownloadedEventArgs> Downloaded;

        public void DownloadFile(string fileName, long fileSize)
        {
            Console.WriteLine($"Downloading file: {fileName}");

            FileDownloadedEventArgs fileDownloadedEventArgs = new FileDownloadedEventArgs(fileName, fileSize);

            //Downloaded?.Invoke(this, new FileDownloadedEventArgs(fileName, fileSize));
            Downloaded?.Invoke(this, fileDownloadedEventArgs);
        }
    }

    class Program
    {
        static void Main()
        {
            DownloadManager downloadManager = new DownloadManager();

            downloadManager.Downloaded += OnFileDownloaded;

            downloadManager.DownloadFile("textfile.txt", 2048);

            downloadManager.Downloaded -= OnFileDownloaded;
        }

        static void OnFileDownloaded(object sender, FileDownloadedEventArgs e)
        {
            Console.WriteLine($"Downloaded file: {e.FileName}, size: {e.FileSize}");
        }
    }
}
