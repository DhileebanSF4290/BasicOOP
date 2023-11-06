using System;
using PolymorphismEmployeeSalary;
namespace PolymorphismEmployeeDetails
{
    class Program
    {
        public static void Main(string[] args)
        {
            FreeLancer freelancer=new FreeLancer("dhileep","arumugam",Gender.male,"BE","Developer",20000,28);
            Console.WriteLine(freelancer.CalculateSalary(28));
            freelancer.DisplayDetails();
            SyncFusion sync=new SyncFusion("kavi","arumugam",Gender.male,"BE","Software developer",30000,25,"Chennai");
           Console.WriteLine(sync.CalculateSalary(24));
            sync.DisplayDetails();
        }
    }
}