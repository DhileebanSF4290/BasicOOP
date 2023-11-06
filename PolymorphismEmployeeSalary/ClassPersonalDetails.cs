using System;

namespace PolymorphismEmployeeSalary
{
    public enum Gender{Default,male,female};
    public abstract class ClassPersonalDetails
    {
        public string Name { get; set; }
        
        public string FatherName { get; set; }
        public Gender MyGender { get; set; }
        public string Qualification { get; set; }
        public ClassPersonalDetails(string name,string fatherName,Gender gender,string qualification)
        {
            Name=name;
            FatherName=fatherName;
            MyGender=gender;
            Qualification=qualification;
        }
        public virtual int CalculateSalary(int workingDays)
        {
             return 0;
        }
      public virtual void DisplayDetails()
      {

      }
        
    }
    public  class FreeLancer : ClassPersonalDetails
    {
        public string Role { get; set; }
        public int SalaryAmount { get; set; }
        public int WorkingDays { get; set; }
        public FreeLancer(string name,string fathername,Gender gender,string qualification,string role,int salaryAmount,int workingDays) : base(name,fathername,gender,qualification)
        {
        Role=role;
        SalaryAmount=salaryAmount;
        WorkingDays=workingDays;
        }
        public override int CalculateSalary(int workingDays)
        {
            return WorkingDays*500;
        }

        public override void DisplayDetails()
        {
           Console.WriteLine($"Your Name : {Name}\nYour Father Name : {FatherName}\nYour Gender : {MyGender}\nYour Qualification : {Qualification}\nYour Role : {Role}\nYour Salary Amount : {SalaryAmount}\n Your Working days : {WorkingDays}");
        }
    }
       class SyncFusion : FreeLancer
       {
        private static int s_employeeID=1000;
        public string EmployeeID { get; }
        public string WorkLocation { get; set; }
             public SyncFusion(string name,string fathername,Gender gender,string qualification,string role,int salaryAmount,int workingDays,string worklocation) : base(name,fathername,gender,qualification,role,salaryAmount,workingDays)
             {
                s_employeeID++;
                EmployeeID="EID"+s_employeeID;
             }
        public override int CalculateSalary(int workingDays)
        {
            return WorkingDays*500;
        }
          public override void DisplayDetails()
        {
           Console.WriteLine($"Your Name : {Name}\nYour Father Name : {FatherName}\nEmployee ID : {EmployeeID}\nYour Gender : {MyGender}\nYour Qualification : {Qualification}\nYour Role : {Role}\nYour Salary Amount : {SalaryAmount}\n Your Working days : {WorkingDays}");
        }


    }
}
