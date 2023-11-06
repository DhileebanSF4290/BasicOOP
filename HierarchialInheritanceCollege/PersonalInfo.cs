using System;

namespace HierarchialInheritanceCollege
{
    public enum Gender{male,female};
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public Gender MyGender { get; set; }
        public string Mail { get; set; }
        
        public PersonalInfo(string name,string fathername,DateTime dob,string phone,Gender gender,string mail)
        {
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Phone=phone;
            MyGender=gender;
            Mail=mail;
        }
        
        
        
    }
}
