using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guid{
    class Program
    {
[STAThread]
        static void Main(string[] args)
        {

            string guid = Guid.NewGuid().ToString().ToUpper();
            Console.WriteLine(guid);
            foreach(string arg in args){
                switch(arg){
                    case("/clip"):
                        Clipboard.SetText(guid);
                        Console.WriteLine("has been copied to the clipboard.");
                        break;
                    case("/?"):
                        Console.Write("Switches:\n\t/?\tPrints this message.\n\t/clip\tCopies the GUID to the clipboard.");
                        break;

                }
            }
        }
    }
}
