using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forest
{
 strom dub = new Dub();
 Dub dub1 = new Dub();

 try
 {
   dub1 rastie();
    DivisionByZeroException e;
 }
catch
{
   Console.WriteLine(e.Message);
}
class VyscholException: Exception
{
    VyscholException() {message = Vyschol };

    override string message
}
class Dub
{
    override public void rastie()
    {
        if (vyschol == true)
        {
            throw new VyscholException();
        }
    }
}

 

    









}
