using System;

namespace DiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix=new int [4,4];
            int sumMainDiagonal = 0;
            int sumOffDiagonal = 0;
            Console.WriteLine("enter elements for a 4*4 array");
            for(int index1=0;index1<4;index1++)
                for(int index2=0;index2<4;index2++)
                {
                    matrix[index1, index2] = Convert.ToInt32(Console.ReadLine());
                    if (index1 == index2)
                        sumMainDiagonal += matrix[index1, index2];
                    else if(index1+index2==3)
                        sumOffDiagonal += matrix[index1, index2];

                }
            Console.WriteLine("sum of diagonal elements = {0}", sumMainDiagonal);
            Console.WriteLine("sum of off diagonal elements = {0}", sumOffDiagonal);
        }
    }
}
