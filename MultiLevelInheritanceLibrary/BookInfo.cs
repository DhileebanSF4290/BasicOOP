using System;

namespace MultiLevelInheritanceLibrary
{
    public class BookInfo : DepartmentDetails
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public BookInfo(string departmentname, string degree,string bookID,string bookname,string authorname,int price) : base(departmentname,degree)
        {
           BookID=bookID;
           BookName=bookname;
           AuthorName=authorname;
           Price=price;
        }
          
          public void DisplayInfo()
          {
            Console.WriteLine($"Department {DepartmentName}\nDegree {Degree}\n BookID {BookID} \n BookName {BookName}\n AuthorName {AuthorName}\nPrice of the book {Price}");
          }
    }
}
