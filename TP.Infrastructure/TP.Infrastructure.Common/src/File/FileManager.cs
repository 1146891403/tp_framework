using FluentFTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Security;

namespace TP.Infrastructure.Common.File
{
    public class FileManager : IFileManager
    {
        private readonly IFtpSetting _ftpSetting;
        private readonly IAESCryptography _aesCryptography;
        private FtpClient _client;

        public FileManager(IFtpSetting ftpSetting, IAESCryptography aesCryptography)
        {
            _ftpSetting = ftpSetting ?? throw new ArgumentNullException(nameof(ftpSetting));
            _aesCryptography = aesCryptography ?? throw new ArgumentNullException(nameof(aesCryptography));
        }

        private async Task ConnectAsync()
        {
            if (_client == null || !_client.IsConnected)
            {
                var credential = new NetworkCredential(_ftpSetting.UserName, _aesCryptography.Decrypt(_ftpSetting.Password));

                _client = new FtpClient(_ftpSetting.Host, _ftpSetting.Port, credential);
                await _client.ConnectAsync();
            }
        }
        
        public async Task CreateDirectoryAsync(string path)
        {
            await ConnectAsync();

            if(!await _client.DirectoryExistsAsync(path))
                await _client.CreateDirectoryAsync(path);
        }

        public async Task<bool> UploadFileAsync(string localPath, string remotePath)
        {
            await CreateDirectoryAsync(remotePath);

            return await _client.UploadFileAsync(localPath, remotePath);
        }

        public async Task<bool> UploadFilesAsync(IEnumerable<string> localPaths, string remoteDir)
        {
            await CreateDirectoryAsync(remoteDir);

            await _client.UploadFilesAsync(localPaths, remoteDir);

            return await Task.FromResult(true);
        }

        public async Task<bool> DownloadAsync(string localPath, string remotePath)
        {
            return await _client.DownloadFileAsync(localPath, remotePath);
        }

        public async Task RemoveAsync(string path)
        {
            await _client.DeleteFileAsync(path);
        }

        public async Task RemoveDirectoryAsync(string path)
        {
            await _client.DeleteDirectoryAsync(path);
        }
    }
}
