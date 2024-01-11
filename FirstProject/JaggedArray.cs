using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class JaggedArray
    {
        static void Main() {
            //int[][] myarray = new int[4][];
            //myarray[0] = new int[] { 1, 2, 3 };
            //myarray[1] = new int[] { 1, 4, 6, 8 };
            //myarray[2] = new int[] { 7, 8 };
            //myarray[3] = new int[] { 9 };

            int[][] myarray =
{
    new int[] {1, 2, 3, 4},
    new int[] {11, 34, 67},
    new int[] {89, 23},
    new int[] {0, 45, 78, 53, 99}
};

            // Length method returns the number of 
            // arrays contained in the jagged array 
            for (int n = 0; n < myarray.Length; n++)
            {

                // Print the row number 
                System.Console.Write("Row({0}): ", n);

                for (int k = 0; k < myarray[n].Length; k++)
                {

                    // Print the elements in the row 
                    System.Console.Write("{0} ", myarray[n][k]);
                }
                System.Console.WriteLine();
            }



            //Jagged Arrays With Multidimensional Arrays
            //int[][,] myarray1 = new int[3][,];
            //myarray1[0] = new int[,] { { 1, 2 }, { 3, 4 } };
            //myarray1[1] = new int[,] { { 4, 5 }, { 9, 0 },{ 1,2} };
            //myarray1[2] = new int[,] { { 9, 5}, { 9, 0 },{ 1,2} };

            int[][,] myarray1 = new int[4][,] {
                                    new int[, ] {{1, 3}, {5, 7}},
                                    new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                    new int[, ] {{7, 8}, {3, 1}, {0, 6}},
                                    new int[, ] {{11, 22}, {99, 88}, {0, 9}}
                                    };


            for (int i = 0; i < myarray1.Length; i++) {
                for (int j = 0; j < myarray1[i].GetLength(0); j++) {
                    for (int k = 0; k < myarray1[i].GetLength(1); k++) {
                        Console.Write(myarray1[i][j,k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
