using System;

namespace MethodOverridingLibraryApplication
{
    public abstract class LibraryClass
    {
        protected static int s_serialNUmber=1000;
        public string SerialNumber { get;}
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }
        
        public abstract void SetBookInfo(string authorName,string bookName,string publisherName,int year);
        public abstract void DisplayInfo();
    }
    class EEEDepartment : LibraryClass
    {
        public new string  SerialNumber { get; set; }
        public override string AuthorName { get; set; }
         public override string BookName { get; set; }
        public override string PublisherName{get; set;}
        public override int Year { get; set; }

        public override void SetBookInfo(string authorName,string bookName,string publisherName,int year)
        {
            s_serialNUmber++;
            SerialNumber="LIB"+s_serialNUmber;
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
           
        }
        public override void DisplayInfo()
        {
             Console.WriteLine($"Your Book's Serial number : {SerialNumber}\nBook Name : {BookName}\nAuthor Name : {AuthorName}\nPublisher Name :  {PublisherName}\nReleased Year : {Year}");
        }


    }
    class CSEDepartment : LibraryClass
    {
         public new string  SerialNumber { get; set; }
         public override string AuthorName { get; set; }
         public override string BookName { get; set; }
        public override string PublisherName{get; set;}
        public override int Year { get; set; }
           public override void SetBookInfo(string authorName,string bookName,string publisherName,int year)
        {
            s_serialNUmber++;
            SerialNumber="LIB"+s_serialNUmber;
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
           
        }
         public override void DisplayInfo()
        {
             Console.WriteLine($"Your Book's Serial number : {SerialNumber}\n Book Name : {BookName}\nAuthor Name : {AuthorName}\n Publisher Name : {PublisherName}\n Released Year : {Year}");
        }
    }
}
