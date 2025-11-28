//using System;
//using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.Linq;
//using System.Numerics;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Binary_Hex_Calculator

//{
//    internal class Conversions
//    {
//        private string? _binary;
//        private string? _denary;
//        private string? _hex;
//        private string? _shift;
//        public Conversions()
//        {
//            string? binary = _binary;
//            string? denary = _denary;
//            string? hex = _hex;
//            string? shift = _shift;
//            //Binary_Denary_Calculator(binary, denary);
//            //Denary_Binary_Calculator(denary, binary);
//            //Binary_Hex_Calculator(binary, hex);
//            Logical_Shift(binary, shift);
//        }
        ////private void Binary_Denary_Calculator(string? binary, string? denary)
        ////{
        ////    Console.WriteLine("Write your binary number");
        ////    binary = Console.ReadLine();
        ////    int bitlength = binary.Length;

        ////    int value = 1;
        ////    int total = 0;
        ////    for (int index = bitlength; index > 0; index--)
        ////    {
        ////        char test = binary[index-1];
        ////        if (test == '1') 
        ////        {
        ////            total += value;
        ////        }
        ////            value *= 2;
        ////    }
        ////    Console.WriteLine(total);
        //}
        //private void Denary_Binary_Calculator(string? binary, string? denary)
        //{
        //    Console.WriteLine("Write your denary number");
        //    denary = Console.ReadLine();
        //    int denary_value = int.Parse(denary);
        //    int binary_value = 0;
        //    while (denary_value >= 0) 
        //    {
        //        int remainder = denary_value % 2;
        //        binary_value += remainder;
        //        denary_value /= 2;
        //        binary_value *= 10;
        //    }
        //    Console.WriteLine(binary_value);
        //}


        //private void Binary_Hex_Calculator(string? binary, string? hex)
        //{
        //    Console.WriteLine("Write your binary number");
        //    binary = Console.ReadLine();
        //    int binary_value = int.Parse(binary);
        //    int binary_length = binary.Length;
        //    for (int index = 0; index < binary_length; index++)
        //    {
        //        int total = 0;
        //        int remainder = binary_value % 10;
        //        total += 1 * remainder;
        //        binary_value /= 10;
        //        remainder = binary_value % 10;
        //        total += 2 * remainder;
        //        binary_value /= 10;
        //        remainder = binary_value % 10;
        //        total += 4 * remainder;
        //        binary_value /= 10;
        //        remainder = binary_value % 10;
        //        total += 8 * remainder;
        //        if (total == 0)
        //        {
        //            Console.WriteLine("0");
        //        }
        //        if (total == 1)
        //        {
        //            Console.WriteLine("1");
        //        }
        //        if (total == 2)
        //        {
        //            Console.WriteLine("2");
        //        }
        //        if (total == 3)
        //        {
        //            Console.WriteLine("3");
        //        }
        //        if (total == 4)
        //        {
        //            Console.WriteLine("4");
        //        }
        //        if (total == 5)
        //        {
        //            Console.WriteLine("5");
        //        }
        //        if (total == 6)
        //        {
        //            Console.WriteLine("6");
        //        }
        //        if (total == 7)
        //        {
        //            Console.WriteLine("7");
        //        }
        //        if (total == 8)
        //        {
        //            Console.WriteLine("8");
        //        }
        //        if (total == 9)
        //        {
        //            Console.WriteLine("9");
        //        }
        //        if (total == 10)
        //        {
        //            Console.WriteLine("A");
        //        }
        //        if (total == 11)
        //        {
        //            Console.WriteLine("B");
        //        }
        //        if (total == 12)
        //        {
        //            Console.WriteLine("C");
        //        }
        //        if (total == 13)
        //        {
        //            Console.WriteLine("D");
        //        }
        //        if (total == 14)
        //        {
        //            Console.WriteLine("E");
        //        }
        //        if (total == 15)
        //        {
        //            Console.WriteLine("F");
        //        }
        //    }
            
        //}
//        private void Logical_Shift(string? binary, string? shift)
//        {
//            Console.WriteLine("Write your binary number");
//            string _binary = Console.ReadLine();
//            int binary = int.Parse(_binary);
//            Console.WriteLine("Left or right shift? 'L' for left and 'R' for right");
//            string _direction = Console.ReadLine();
//            char direction = char.Parse(_direction);
//            Console.WriteLine("How many places? 1, 2 or 3?");
//            string _shift = Console.ReadLine();
//            int shift = int.Parse(_shift);
//            int index=0;
//            if (shift == 1)
//            {
//                index = 10;
//            }
//            if (shift == 2)
//            {
//                index = 100;
//            }
//            if (shift == 3)
//            {
//                index = 1000;
//            }
//            if (direction == 'L')
//            {
//                binary = binary * index;
//            } 
//            if (direction == 'R')
//            {
//                binary = binary / index;
//            }
//            Console.WriteLine("Your new binary number is: " + binary);
//        }
//    }
//}
