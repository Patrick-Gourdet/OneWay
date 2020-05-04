using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace BitWise
{
    class Program
    {
        static int loop = 1;
        static bool Bit(char c, ref int checker)
        {
            Console.WriteLine($">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> LOOP : {loop} START<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine($"This is the char {c} this is the char after conversion {c - 'a'}");
            Console.WriteLine("The bit shift is set up as the right operand if the base and the right operand dictates how many bits are to be shifted");
            Console.WriteLine($" { 1 << 23}  1 is shifted by 23");
            Console.WriteLine($" {23<<1}  23 is shifted by 1");
            Console.WriteLine("\n");
            Console.WriteLine("SEE WHAT SHIFT CHANGES\n");

            Console.WriteLine($"This is the char after a bit wise shift left << by 1 {1 << (c - 'a')} ");
            Console.WriteLine($"This is the char after a bit wise shift right >> by 1 {1 >> (c - 'a')} ");
            Console.WriteLine("\n");
            Console.WriteLine($"This is the char after a bit wise shift left << by 2 {2 << c - 'a'}");
            Console.WriteLine($"This is the char after a bit wise shift left << by 1 and Anded with Checker & {checker &(1 << c - 'a')}");
            Console.WriteLine("\n");
            Console.WriteLine("SEE VALUES OF CHECKER\n");
            Console.WriteLine($"This is the result of checker  {checker} \n");
            Console.WriteLine("SEE VALUES OF VARIABLES IN BINARY\n");
            Console.WriteLine($"This is c - 'a' = int {c - 'a'} to binary {Convert.ToString(Convert.ToInt32(c - 'a'),2)}");
            Console.WriteLine($"This is 1 << c - 'a' = int {1 << c - 'a'} to binary {Convert.ToString(Convert.ToInt32(1 << c - 'a'), 2)}");
            Console.WriteLine("\n");
            Console.WriteLine($"This is checker = {checker} and the binary representation id {Convert.ToString(checker, 2)}");
            Console.WriteLine("\n");
            Console.WriteLine($"This is checker = {checker} : {Convert.ToString(checker, 2)} & char {c - 'a' } {Convert.ToString(Convert.ToInt32(1 << c - 'a'), 2)} \n Equates to {(checker & (1 << c - 'a'))}");
            Console.WriteLine("\n");
            if ((checker & (1 << c - 'a')) > 0)
            {
                return false;
            }
            checker |= (1 << c - 'a');
            Console.WriteLine($"The new value of checker is after OR checker |= (1 << c - 'a') { checker |= (1 << c - 'a')}");
            return true;
        }
        static void Main(string[] args)
        {
            string ToCheck = "FEpedite".ToLower();
            int checker = 0;
            foreach (var c in ToCheck.ToCharArray())
            {
                Console.WriteLine(Bit(c, ref checker).ToString());
                Console.WriteLine($">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> LOOP : {loop}  END<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                loop++;

            }
        }
    }
}
