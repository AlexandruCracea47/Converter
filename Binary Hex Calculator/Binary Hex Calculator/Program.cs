// See https://aka.ms/new-console-template for more information
//using Binary_Hex_Calculator;


////converting between binary, denary, and hexadecimal in classes
////use different classes to make calculations


//Conversions conversions = new Conversions();
//private void Logical_Shift(string? binary, string? shift)
{
    Console.WriteLine("Write your binary number");
    string _binary = Console.ReadLine();
    int binary = int.Parse(_binary);
    Console.WriteLine("Left or right shift? 'L' for left and 'R' for right");
    string _direction = Console.ReadLine();
    char direction = char.Parse(_direction);
    Console.WriteLine("How many places? 1, 2 or 3?");
    string _shift = Console.ReadLine();
    int shift = int.Parse(_shift);
    int index = 0;
    if (shift == 1)
    {
        index = 10;
    }
    if (shift == 2)
    {
        index = 100;
    }
    if (shift == 3)
    {
        index = 1000;
    }
    if (direction == 'L')
    {
        binary = binary * index;
    }
    if (direction == 'R')
    {
        binary = binary / index;
    }
    Console.WriteLine("Your new binary number is: " + binary);
}
    

