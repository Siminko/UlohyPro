using System;
using System.Collections.Generic;

namespace forest
{
    internal class Branch
    {
        protected double radius, height;
        private static double radiusIncrement = 0.01;
        private static double heightIncrement = 2.0;

        public double Volume
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2) * height * 1.0 / 3.0;
            }
        }

        public Dictionary<string, double> Attributes { get; private set; }

        public Branch()
        {
            this.height = 0;
            this.Attributes = new Dictionary<string, double>
            {
                {"Radius", radius},
                {"Height", height}
            };
        }

        public Branch(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            this.Attributes = new Dictionary<string, double>
            {
                {"Radius", radius},
                {"Height", height}
            };
        }

        ~Branch()
        {
            Console.WriteLine("The tree was destroyed.");
        }

        public void Growing() //daily
        {
            radius += radiusIncrement / Tree.daysOfYear;
            height += heightIncrement / Tree.daysOfYear;
            UpdateAttributes();
        }

        private void UpdateAttributes()
        {
            Attributes["Radius"] = radius;
            Attributes["Height"] = height;
        }
    }
}
