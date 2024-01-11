using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forest
{
    class  Listnaty : Tree
    {
        public Listnaty()
        {

        }
        ~Listnaty()
        {

        }
        public new bool Rastie()
        {
            radius == 0.01;
            height == 1;

        }
            public virtual double Obsah()
        {
            Volume = Math.PI * radius * radius * height * (1.0 / 3.0);
             return Volume;
        } 

    }
}

