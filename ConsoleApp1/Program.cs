using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Excep("Test1");


        }
        public void Excep (string st)
        {
            switch (st.ToUpper())
            {
                case "Test1":
                    break;
                case "Test2":
                    break;
                case "Test3":
                    break;
                case "Test4":
                    break;
               
                                       
                default:
                    CustomException ex = new CustomException("Test is not avaliable");
                    Console.WriteLine(ex);
                    break; 
                    

                   
            }
        }

    }
}
