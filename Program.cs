
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{

    static void Main(string[] args)
    {
        int s;
        s = Convert.ToInt32(Console.ReadLine());
        Square_Matrix m = new Square_Matrix(s);
        m.SetOneValue(1);
        Console.WriteLine(m.ToString());
        string a = Console.ReadLine();
    }
   
}



























