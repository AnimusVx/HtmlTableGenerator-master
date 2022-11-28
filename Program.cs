using HTMLTABLEGENERATOR.DataAccess;
using HTMLTABLEGENERATOR.LibAlgorithm;


string path = Directory.GetCurrentDirectory();
var fname = "movies.json";
var rData = new ReadFromJson(Path.Combine(path, fname));

var a = new ListToHtml(rData.Movie);

var w = new WriteToHTML(a.ListToString());

w.Writer(path, "output.html");
