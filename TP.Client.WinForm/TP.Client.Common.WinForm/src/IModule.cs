namespace TP.Client.WinForm.Common
{
    public interface IModule
    {
        string Number { get; }

        string ModuleName { get; }

        void Initialize();
    }
}
