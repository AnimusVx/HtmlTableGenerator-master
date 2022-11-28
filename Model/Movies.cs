namespace HTMLTABLEGENERATOR.Model;

class Movies
{
    public int id { get; set; }
    public string? title { get; set; }
    public string? rating { get; set; }
    public string? genre { get; set; }
    public int? duration { get; set; }

    public override string ToString()
    {
        return id + " - " + title + " - " + rating + " - " + genre + " - " + duration;
    }
}
