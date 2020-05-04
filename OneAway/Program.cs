using System;

namespace OneAway
{
    internal class Program
    {
        private static bool CheckString(ref long checker, char c, char c1)
        {
            var ch = 1 << (c1 - 'a');
            if ((checker & ch) > 0) return false;
            checker |= 1 << (c - 'a');
            return true;
        }

        private static void Main(string[] args)
        {
            var one = 0;
            var first = "pale";
            var second = "paale";
            if (Math.Abs(first.Length - second.Length) >= 2) Console.WriteLine("False");

            long checker = 0;
            var found = false;
            var len = first.Length < second.Length ? first.Length : second.Length;
            for (var i = 0; i < len; i++)
            {
                if (first.Length < second.Length) found = CheckString(ref checker, first[i], second[i + one]);
                else if (first.Length > second.Length) found = CheckString(ref checker, first[i + one], second[i]);

                if (found)
                    continue;
                one++;

                if (one == 2) break;
            }
        }
    }
}