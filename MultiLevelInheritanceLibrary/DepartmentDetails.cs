using System;

namespace MultiLevelInheritanceLibrary
{
    public class DepartmentDetails
    {
        public string DepartmentName { get; set; }
        
        public string Degree { get; set; }
        
        public DepartmentDetails(string departmentname, string degree)
        {
            DepartmentName=departmentname;
            Degree=degree;
        }
    }
}
