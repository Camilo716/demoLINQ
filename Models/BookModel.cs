namespace demoLINQ.Models;

public class BookModel
{
    public string Tittle{get;set;}
    public int PageCount{get;set;}
    public string Status{get;set;}
    public DateTime PublishedDate{get;set;}
    public string[] Authors{get;set;}
    public string[] Categories{get;set;}

}