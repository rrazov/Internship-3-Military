using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {   
            //tank
            var leopard2 = new Tank(61.7,72);
            //warship
            var zumwaltClass = new Tank(35000,56);
            //amfibia
            var amfibiaPTS = new Amfibia(17, 60);

            var tfc = leopard2.Print(50,15);
            System.Console.WriteLine(tfc);
        
            
            

            


            
        }
    }
}
