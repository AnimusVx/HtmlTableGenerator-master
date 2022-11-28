namespace HTMLTABLEGENERATOR.DataAccess;

class WriteToHTML
{
    private string html;
    public WriteToHTML(string html)
    {
        this.html = html;
    }

    public void Writer(string path, string fName)
    {
        var combo = Path.Combine(path, fName);
        File.WriteAllText(combo, html);
    }
}
