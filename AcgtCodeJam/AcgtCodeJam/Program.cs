using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AcgtCodeJam
{
    class Program
    {
          public int MinChanges(int maxPeriod, string acgt)
        {
            int r = 0;
            int period = maxPeriod;
            int[] arr = new int[maxPeriod];

            while (period != 0)
            {
                
                for (int j = 0; j < period; j++)
                {
                    for (int i = j; i < acgt.Length - period; i = i + period)
                    {

                        if (acgt[j] != acgt[i + period])
                        {
                            r++;

                        }
                    }
                   
                }
                period--;
                arr[period] = r;

                r = 0;
            }
            Array.Sort(arr);
            Console.Write("number of replacements:");
           
                return arr[0];
               
            
        }
    
        static void Main(string[] args)
        {
            
            string str="";
            int i=0,strNumber;
            
            Program p= new Program ();
            Console.WriteLine("enter no of string:");
            strNumber=(int)Convert.ToInt32(Console.ReadLine());
            string[] s = new string[strNumber];
            for (int K=0;K < s.Length; K++)
            {
                Console.WriteLine("Enter string:");
                s[K]= Console.ReadLine();
                str += s[K];
            }
            Console.WriteLine("Enter period:");
            i = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(p.MinChanges(i,str));
        }
    }
}

