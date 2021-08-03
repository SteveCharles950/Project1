using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");


    Author a1 = new Author("Rick","Riordan");
    a1.Email = "rrick@gmail.com";
    Author a2 = new Author("JK", "Rowling");
    a2.Email = "jkrowl@gmail.com";

    a1.DisplayInfo();
    a2.DisplayInfo();

    Book b1 = new Book("34567", "Green Eggs and Ham",a1);
    b1.AuthorInfo = a1;
    
     Book b2 = new Book("34589", "Sorcer's stone", a2);
      b2.AuthorInfo = a2;
     Book b3 = new Book("34511", "Paper Towns",a1);
      b3.AuthorInfo = a1;
     Book b4 = new Book("20036", "So be It", a2,Convert.ToDateTime("06/13/2011")," Simon Schuster");
       b4.AuthorInfo = a2;
     Book b5 = new Book("22334", "Lightning Thief",a1, Convert.ToDateTime("01/13/2009"),"Penguin Group");
       b5.AuthorInfo = a1;
     Book b6 = new Book("10108", "Unfortunate events",a2,Convert.ToDateTime("09/15/2003"),"Ny Times");
       b6.AuthorInfo = a2;

       a1.AddBook(b1);
      a1.AddBook(b3);
       a1.AddBook(b5);

        a1.AddBook(b2);
         a1.AddBook(b4);
          a1.AddBook(b6);

          a1.DisplayBooks();
          a2.DisplayBooks();

          a1.RemoveBook("34567");
          a1.DisplayBooks();



  }
}