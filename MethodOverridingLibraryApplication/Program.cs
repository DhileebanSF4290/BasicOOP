using System;
using MethodOverridingLibraryApplication;
namespace MethodOverrridingLibraryApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            EEEDepartment eeeClass=new EEEDepartment();
            eeeClass.SetBookInfo("dhileep","do epic shit","kavi",2019);
            eeeClass.DisplayInfo();
            CSEDepartment cse =new CSEDepartment();
            cse.SetBookInfo("kalai","Roots","dhileep",2020);
            cse.DisplayInfo();
        }
    }
}