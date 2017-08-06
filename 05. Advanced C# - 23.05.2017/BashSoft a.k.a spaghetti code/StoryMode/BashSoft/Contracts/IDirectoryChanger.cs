namespace BashSoft.Contracts
{
    public interface IDirectoryChanger
    {
        void ChangeCurrentDirectoryRelative(string relativePath);

        void ChangeCurrentDirectoryAbsoulute(string absoulutePath);
    }
}
