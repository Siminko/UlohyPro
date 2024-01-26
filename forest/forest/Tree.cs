using forest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forest
{
    class Tree : IOrganizmus
    {
        private double age; //year
        public double radius, height;
        private static double widthIncrement = 0.01; // mm/year
        private static double heightIncrement = 2.0; // mm/year
        public static double daysOfYear = 365.25;
       

        public Tree()
        {
            age = 0;
            radius = 0;
            height = 0;
        }

        ~Tree()
        {
            Console.WriteLine("The tree was destroyed.");
        }

        public void Growing() //daily
        {
            age += 1 / daysOfYear;
            radius += widthIncrement / daysOfYear;
            height += heightIncrement / daysOfYear;
        }

        public string GetInfo()
        {
            return $"---------- Tree info ----------\nAge = {this.age}\nRadius = {this.radius}\nHeight = {this.height}\n";
        }

        public virtual void Rastie()
        {
            throw new NotImplementedException();
        }

        void IOrganizmus.GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
