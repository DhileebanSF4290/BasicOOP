using System;
namespace MultipleInheritanceFamily
{
    class Program
    {
        public static void Main(string[] args)
        {
            RegisterPerson person1=new RegisterPerson("dhileep",Gender.male,new DateTime(2001/12/12),"044 654321","987654321",Status.Single,"arumugam","dheepa","Ponnappur,Orathanadu,Thanjavur",1,new DateTime(2018/07/03));
            RegisterPerson person2=new RegisterPerson("Raja",Gender.male,new DateTime(2003/10/15),"044 56239","8613082467",Status.Single,"arumugam","dheepa","Ponnappur,Orathanadu,Thanjavur",1,new DateTime(2015/08/20));
        }
    }
}