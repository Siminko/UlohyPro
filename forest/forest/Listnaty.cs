using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forest
{
    class  Listnaty : Tree
    {
        public double Volume;

        public Listnaty(double _radius, double _height)
        {
            radius = _radius;
            height = _height;
        }
        ~Listnaty()
        {

        }
        public new bool Rastie()
        {
            radius = 0.01;
            height = 1;
            return true;

        }
            public virtual double Obsah()
        {
            Volume = Math.PI * radius * radius * height * (1.0 / 3.0);
            return Volume;
        } 

    }
}

