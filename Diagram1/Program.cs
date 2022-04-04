using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram1
{
    public class Student
    {
        private int _rollno;
        private string _name;
        private string _coursename;

        private float _coursefee;
        private float _totalfee;

        private float _feepaid;
        private static float _servicetax = 12.3F;
        #region Properties
        public int Rollno { get { return _rollno; } set { _rollno = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string CourseName { get { return _coursename; } set { _coursename = value; } }
        public float Coursefee { get { return _coursefee; } set { _coursefee = value; } }
        public float Feepaid { get { return _feepaid; } set { _feepaid = value; } }
        public static float ServiceTax
        {
            get { return _servicetax; }
            set { _servicetax = value; }
        }
        #endregion

        public Student(int Rollno, string Name, string CourseName)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this._coursename = CourseName;
        }

        public float TotalFee
        {   
            get
            {
                return _totalfee;
            }
            
            set
            {
                _totalfee = value;
            }
        }

        public float DueAmount
        {
            get
            {
                return (_totalfee - _feepaid);
            }
        }


        public void Payment(int amount) 
        {
            
            Console.WriteLine($"Your payment of {amount} is Successfull");
            Console.WriteLine();
            Feepaid = amount;
        }
        public void Print() 
        { 
            Console.WriteLine("Print Method Invoked");
            Console.WriteLine(Rollno);
            Console.WriteLine(Name);
            Console.WriteLine(CourseName);
            Console.WriteLine(Coursefee);
            Console.WriteLine(TotalFee);
            Console.WriteLine(Feepaid);
        }

    }


    public class UseStudent
    {
        private static void Main(string[] args)
        {
            Student S1 = new Student(1, "Aftab", "C#");
            
            S1.Coursefee = 2000;
            
            S1.TotalFee = ((S1.Coursefee * 12.3F) / 100) + S1.Coursefee;

            
            Console.WriteLine($"Your Payable Amount is {S1.TotalFee}");
            Console.WriteLine();
            
            S1.Payment(1000);
            
            Console.WriteLine($"Your Due Amount is {S1.DueAmount}");
            Console.WriteLine();



            //Student S2 = new Student(2, "Mustafa", "ASP.NET");
            
            //S2.Coursefee = 3000;
        }
    }
}
