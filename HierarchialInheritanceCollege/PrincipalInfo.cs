using System;

namespace HierarchialInheritanceCollege
{
    public class PrincipalInfo : PersonalInfo
    {
        public string PrincipalID { get; set; }
        public string Qualification { get; set; }
        public int Experience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipalInfo(string name,string fathername,DateTime dob,string phone,Gender gender,string mail,string principalid,string qualification,int experience,DateTime doj) : base(name,fathername,dob,phone,gender,mail)
        {
            PrincipalID=principalid;
            Qualification=qualification;
            Experience=experience;
            DateOfJoining=doj;
        }
        
        public void ShowInfo()
        {
             Console.WriteLine($"Student Name : {Name}\nStudent's FatherName : {FatherName}\nStudent's Date Of Birth : {DOB}\n Student's Phone NUmber : {Phone}\nStudent's Gender : {MyGender}\nStudent Mail ID : {Mail}\nPrincipal ID : {PrincipalID}\nPrincipal QUalification : {Qualification}\nExperience : {Experience}\nDate of Joining : {DateOfJoining}");
        }
        
        
    }
}
