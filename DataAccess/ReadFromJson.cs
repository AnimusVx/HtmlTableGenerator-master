using HTMLTABLEGENERATOR.Model;
using System.Text.Json;
namespace HTMLTABLEGENERATOR.DataAccess;


class ReadFromJson
{
    public List<Movies> Movie { get; set; }
    public ReadFromJson(string path)
    {
        var json = File.ReadAllText(path);
        Movie = JsonSerializer.Deserialize<List<Movies>>(json);
    }
}
