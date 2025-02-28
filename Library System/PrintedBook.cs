using System;

public class PrintedBook : Book
{
    public int Pages { get; set; }
    public PrintedBook(string title, string author, int year, int pageCount)
        : base(title, author, year
    {
        Page = new pagecount;

    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Printed Book: {Title} by {Author}, published in {Year}, Pages: {pagecount");
    }
}