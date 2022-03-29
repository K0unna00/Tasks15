using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee
    {
        private string _employeeName;
        private string _surname;
        public string Name { get => _employeeName; set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if (!char.IsLetter(item))
                    {
                        count++;
                    }
                }
                if (count == 0 && char.IsUpper(value[0]))
                {
                    _employeeName = value;
                }
            } }
        public string Surname
        {
            get => _surname; set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if (!char.IsLetter(item))
                    {
                        count++;
                    }
                }
                if (count == 0 && char.IsUpper(value[0]))
                {
                    _surname = value;
                }
            }
        }
        public int Salary { get; set; }



    }
}
