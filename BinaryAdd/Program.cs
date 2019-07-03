using System;

namespace BinaryAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "1001111100110101";
            string second = "1000100011110011";

            string result = add(first, second);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(result);
        }

        public static string add(string first, string second)
        {
            string result = "";

            char[] f = first.ToCharArray();
            char[] s = second.ToCharArray();

            string[] r = new string[f.Length];
            for(int i = 0; i < r.Length; i++)
            {
                r[i] = "0";
            }

            int largest = Math.Max(f.Length, s.Length);

            for(int i = largest - 1; i >= 0; i--)
            {
                char f1 = f[i];
                char s1 = s[i];

                int value = Int32.Parse(f1.ToString()) + Int32.Parse(s1.ToString()) + Int32.Parse(r[i]);
                if (value == 0)
                {
                    r[i] = "0";
                }
                else if(value == 1)
                {
                    r[i] = "1";
                }
                else if(value == 2)
                {
                    r[i] = "0";
                    try
                    {
                        r[i - 1] = "1";
                    } catch { }
                }
                else if(value == 3)
                {
                    r[i] = "1";
                    try
                    {
                        r[i - 1] = "1";
                    } catch { }
                }
            }

            foreach(string str in r)
            {
                result += str;
            }

            return result;
        }
    }
}
