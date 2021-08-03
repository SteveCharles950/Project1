using System.Collections.Generic;
using System;

class Author : Person {

private List<Book> books = new List<Book>();
public string Email {get; set;}

public Author () : base(){

   Console.WriteLine("Author constructor");

}

public Author ( string fname, string lname) : base (fname, lname){
  Console.WriteLine("Author constructor");
}


public override void DisplayInfo(){
base.DisplayInfo();

Console.WriteLine("first and last name is "+ FirstName +" "+ LastName + " email is: " + Email);
}

public void DisplayBooks(){
  foreach( Book name in books){
    name.Display();
  }
}

public void AddBook( Book bookItem){

  books.Add(bookItem);
}


public void RemoveBook(string isbn){
   foreach( Book name in books){
 if(name.ISBN == isbn)
    books.Remove(name);
 
}
}


}