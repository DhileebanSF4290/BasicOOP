using System;
namespace HierarchialInheritanceCollege
{
    class Program
    {
        public static void Main(string[] args)
        {
            TeacherInfo teacher=new TeacherInfo("dhileep","arumugam",new DateTime(2001/12/02),"0845707315",Gender.male,"dhileep@123","TC101","CSE","C++","B.Ed",5,new DateTime(2019/07/14));
             TeacherInfo teacher1=new TeacherInfo("Raja","arumugam",new DateTime(2002/10/20),"084982315",Gender.male,"raja@123","TC102","ECE","C","B.Ed",7,new DateTime(2018/09/25));
             StudentInfo student=new StudentInfo("kavi","arumugam",new DateTime(2002/07/14),"98765432",Gender.male,"kavi@321","SID101","BE","CSE",3);
              StudentInfo student1=new StudentInfo("kalai","chandrabose",new DateTime(2002/11/14),"92639086",Gender.male,"kalai@321","SID121","ME","MECH",2);
              PrincipalInfo principal=new PrincipalInfo("kavi","arumugam",new DateTime(2002/07/14),"98765432",Gender.male,"dhileep@456","PID101","M.Phil",8,new DateTime(2019/11/12));
               PrincipalInfo principal2=new PrincipalInfo("aravind","chennaiyan",new DateTime(2003/10/14),"98765432",Gender.male,"caravind@456","PID103","M.Phil",10,new DateTime(2019/11/12));
               teacher.ShowDetails();
               teacher1.ShowDetails();
               student.ShowDetails();
               student1.ShowDetails();
               principal.ShowInfo();
               principal2.ShowInfo();
        } 
    }
}