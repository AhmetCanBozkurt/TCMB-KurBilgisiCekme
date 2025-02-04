using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TCMBKurBilgisCekme;

namespace TestProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GetKur kur = new GetKur();


            foreach (var item in kur.GetKurList()) {

                Console.WriteLine(item);
            
            }
        
            Console.ReadLine();



                 }
    }
}
