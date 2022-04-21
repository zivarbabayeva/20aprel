using System;
using System.Collections.Generic;
using System.Text;

namespace task20aprel.Models
{
    class Student
    {
        public int Id;
        public int TotalCount;
        public string Name;
        public string Surname;
        private string _fullName;
        private string _groupNo;
        public byte Age;
        public Student(string groupNo, string fullName)
        {
            GroupNo = $"{FullName[0]}{Id}";
            Id++;
            TotalCount++;
            FullName = $"{Name}\n{Surname}";
            GroupNo = groupNo;
            FullName = fullName;
        }
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                while (CheckGroupNo(value))
                {
                    Console.WriteLine("Qrup nomresinin duzgun daxil et");
                    value = Console.ReadLine();
                }
            }
        }
        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length >= 4)
            {
                bool checkUpper = false;
                bool checkDigit = false;
                foreach (char item in groupNo)
                {
                    if (char.IsUpper(groupNo[0]))
                    {
                        checkUpper = true;
                    }
                    else if (char.IsDigit(item))
                    {
                        checkDigit = true;
                    }
                }
                if (checkUpper && checkDigit)
                {
                    return true;
                }
            }
            return false;
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                while (CheckFullName(value))
                {
                    Console.WriteLine("Duzgun daxil et");
                    value = Console.ReadLine();
                }
                _fullName = value;
            }
        }
        public bool CheckFullName(string fullName)
        {
            bool checkName=false;
            bool checkSurname=false;
            bool checksymbol = false;
         
            string _fullName = fullName.Split(' ');
            foreach (char item in fullName)
            {
                String Name = "";
                for (int i = 0; i != fullName.Length; i++)
                {
                    if (i != fullName.Length - 1)
                    {
                        if (i == 0)
                        {
                            Name = Name + fullName[i];
                        }
                        else
                        {
                            Name = Name + " " + fullName[i];
                        }
                    }
                    return true;
                   
                 string Surname = "";
                 Surname=fullName[fullName.Length - 1].ToString();
                 return true;
                    if (char.IsWhiteSpace(item))
                    {
                        checksymbol = true;
                    }
                }
            }
            if (checkName && checkSurname && checksymbol)
            {
                return true;
            }
            return false;
        }   
    }
}
       
       

