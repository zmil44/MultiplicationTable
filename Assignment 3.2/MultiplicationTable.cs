/*Zachary Miller
 * 11/18/2017
 * assignment 3.2
 * The purpose of this program is to create and display a multiplication table
 * MultiplicationTable.cs
 * Bellevue University
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._2
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int[,] table = new int[11,11];
            FillTable(table);
            DisplayOutput(table);
        }

        private static void FillTable(int[,] table) //fills the table array
        {
            for(int i = 1;i<table.GetLength(0);i++) //fills the first row of the array
            {
                table[i,0] = i;
            }
            for(int j=1;j<table.GetLength(1);j++)//fills the first collumn of the array
            {
                table[0,j] = j;
            }
            

            for (int i = 1; i < 11; i++) //fills the rest of the array by multiplying i by j
            {
                for (int j = 1; j < 11; j++)
                {
                    table[i,j] = i*j;
                }
            }
        }

        private static void DisplayOutput(int[,] table)//will display the table
        {
            for(int i=0; i<table.GetLength(0);i++) //nested for loop to display the table in its correct format
            {
                for(int j=0;j<table.GetLength(1);j++)
                {
                    Console.Write(table[i,j] + "\t"); //print the number at the specified array location and then go forward a tab
                }
                Console.Write("\n");//move to next line
            }
            Console.Read(); //pause the console
        }
    }
}
