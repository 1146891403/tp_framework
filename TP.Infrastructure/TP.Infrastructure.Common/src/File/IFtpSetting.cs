namespace TP.Infrastructure.Common.File
{
    public interface IFtpSetting
    {
        string Host { get; }

        int Port { get; }

        string UserName { get; }

        string Password { get; }
    }
}
