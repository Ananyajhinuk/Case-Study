using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[12][];
            int[] sum = new int[100];
            int temp = 0;

            sum[0] = 0;

            for(int i=0; i<12; i++)
            {
                Console.WriteLine("month number :{0}",(i+1));
                Console.WriteLine("Enter the Number of salesman:");
                int v = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the sales of each saleman:");
                jaggedArray[i] = new int[v];

                for(int j=0; j<v; j++)
                {
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                    sum[i] += jaggedArray[i][j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sale of each month: ");
            for(int k=0; k<12; k++)
            {
                Console.WriteLine(sum[k]);
                temp += sum[k];
            }

            Console.WriteLine("Annual sale is:{0}",temp);
        }
        
    }
}
