using System;

class Book 
{
  public string ISBN {get; set;}
  public string Title {get; set;}
  public Author AuthorInfo {get; set;}
  public DateTime PublishedOn {get; set;}
  public string PublishedBy {get; set;}

public Book(){

} 

public Book(string iSBN, string title, Author authorInfo)
{
ISBN = iSBN;
Title = title;
AuthorInfo = authorInfo;
PublishedOn = Convert.ToDateTime("08/02/2021");
PublishedBy = "Unknown";

 Console.WriteLine("Book constructor");
}

public Book(string isbn, string title, Author authorInfo, DateTime publishedOn, string publishedBy){
  ISBN = isbn;
Title = title;
AuthorInfo = authorInfo;
PublishedOn = publishedOn;
PublishedBy = publishedBy;

 Console.WriteLine("Book constructor");

}

public void Display(){
    Console.WriteLine("Book " + Title + " was written by "+ AuthorInfo + " and published on " + PublishedOn );
}


/*get 
{
return.PublishedOn;
}
set
{
PublishedOn = DateTime.Parse;
}*/




}