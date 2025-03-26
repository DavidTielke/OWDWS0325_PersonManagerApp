namespace DavidTielke.PMA.Data.FileStoring;

public interface IFileReader
{
    IEnumerable<string> ReadLines(string path);
}