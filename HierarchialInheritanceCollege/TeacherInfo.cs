using System;

namespace HierarchialInheritanceCollege
{
    public class TeacherInfo: PersonalInfo
    {
        public string TeacherID { get; set; }
        
        public string Department { get; set; }
        public string TeachingSubject { get; set; }
         public string Qualification { get; set; }
         public int Experience { get; set; }
         public DateTime DateOfJoining { get; set; }
         
         public TeacherInfo(string name,string fathername,DateTime dob,string phone,Gender gender,string mail,string teacherid,string department,string teachingsubject,string qualification,int experience,DateTime doj) : base(name,fathername,dob,phone,gender,mail)
         {
            TeacherID=teacherid;
            Department=department;
            TeachingSubject=teachingsubject;
            Qualification=qualification;
            Experience=experience;
            DateOfJoining=doj;
         }
         public void ShowDetails()
         {
            Console.WriteLine($"Student Name : {Name}\nStudent's FatherName : {FatherName}\nStudent's Date Of Birth : {DOB}\n Student's Phone NUmber : {Phone}\nStudent's Gender : {MyGender}\nStudent Mail ID : {Mail}\nTeacher ID : {TeacherID}\nDepartment : {Department}\nTeaching Subject : {TeachingSubject}\nQualification : {Qualification}\nExperience of Teacher : {Experience}\nTeacher's Date OF Joining : {DateOfJoining}");
         }
        
        
    }
}
