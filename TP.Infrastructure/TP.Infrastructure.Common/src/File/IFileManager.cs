using System.Collections.Generic;
using System.Threading.Tasks;

namespace TP.Infrastructure.Common.File
{
    public interface IFileManager
    {
        Task CreateDirectoryAsync(string path);

        Task<bool> UploadFileAsync(string localPath, string remotePath);

        Task<bool> UploadFilesAsync(IEnumerable<string> localPaths, string remoteDir);

        Task<bool> DownloadAsync(string localPath, string remotePath);

        Task RemoveAsync(string path);

        Task RemoveDirectoryAsync(string path);
    }
}
