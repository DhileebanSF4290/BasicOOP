using System;

namespace HierarchialInheritanceCollege
{
    public class StudentInfo : PersonalInfo
    {
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        
        public StudentInfo(string name,string fathername,DateTime dob,string phone,Gender gender,string mail,string studentID,string degree,string department,int semester) : base(name,fathername,dob,phone,gender,mail)
        {
            StudentID=studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        public void ShowDetails()
        {
             Console.WriteLine($"Student Name : {Name}\nStudent's FatherName : {FatherName}\nStudent's Date Of Birth : {DOB}\n Student's Phone NUmber : {Phone}\nStudent's Gender : {MyGender}\nStudent Mail ID : {Mail}\nStudent ID : {StudentID}\nDegree : {Degree}\nDepartment : {Department}\nSemester : {Semester}");
        }
        
    }
}
