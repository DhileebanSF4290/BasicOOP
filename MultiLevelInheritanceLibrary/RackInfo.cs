using System;

namespace MultiLevelInheritanceLibrary
{
    public class RackInfo : BookInfo
    {
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }
        
        public RackInfo(string departmentname, string degree,string bookID,string bookname,string authorname,int price,int racknumber,int columnnumber) : base(departmentname,degree,bookID,bookname,authorname,price)
        {
            RackNumber=racknumber;
            ColumnNumber=columnnumber;
        }
        public void Method1()
        {

        }
    }
}
