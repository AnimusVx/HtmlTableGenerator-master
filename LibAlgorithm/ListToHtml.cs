using HTMLTABLEGENERATOR.Model;

namespace HTMLTABLEGENERATOR.LibAlgorithm;

class ListToHtml
{
    private List<Movies> Movie { get; set; }

    public ListToHtml(List<Movies> m)
    {
        Movie = m;
    }

    public string ListToString()
    {
        string ret = @"<table><th><tr><td>id</td><td>title</td><td>rating</td><td>genre</td><td>duration</td></tr></th><tbody>";

        foreach (var m in Movie)
        {
            ret += @"<tr>";
            ret += @"<td>" + m.id.ToString() + @"</td>";
            ret += @"<td>" + m.title + @"</td>";
            ret += @"<td>" + m.rating + @"</td>";
            ret += @"<td>" + m.genre + @"</td>";
            ret += @"<td>" + m.duration.ToString() + @"</td>";
            ret += @"</tr>";
        }
        ret += @"</tbody></table>";

        return ret;
    }
}
