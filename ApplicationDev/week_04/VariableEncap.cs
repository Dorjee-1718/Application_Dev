using System;
namespace ApplicationDev.week_04
{
    public class VariableEncap
    {
        private int MyAge;
        private string MyName;
        public VariableEncap(string name = "Dorjee",int age = 18)
        {
            MyAge = age;
            MyName = name;

        }
       
        public int Age
        {
            get{ return MyAge; }
            set { MyAge = value; }
        }

        public string Name
        {
            get{ return MyName; }
            set { MyName = value; }
        }
    }
}

