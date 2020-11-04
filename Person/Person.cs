using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            } 
        }

        public virtual int Age 
        {
            get
            {
                return age;
            }
            protected set
            {
                if(age < 0)
                {
                    throw new ArgumentException("Age can't be zero");
                }
                age = value;
            }
        }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format($"Name: {Name}, Age: {Age}"));
            return sb.ToString();
        }
    }
}
