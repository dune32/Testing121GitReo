using System;


    public class Ebook : Book
{
    public string FileFormat { get; set; }
    public double FileSize { get; set; }
    public Ebook(string title, string author, int year, string fileFormat, double fileSize)
        : base(title, author, year)
    {
        FileFormat = fileFormat;
        FileSize = fileSize;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Ebook: {Title} by {Author}, published in {Year}, Format: {FileFormat}, Size: {FileSize}MB");
    }
}

