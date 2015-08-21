using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandFiles_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете израз");
            string math_exp = Console.ReadLine();
            math_exp += " ";
            int count = 0, count1 = 0;
            bool chek = true;
            for (int i = 0; i < math_exp.Length; i++)
            {
                if (math_exp.StartsWith(")"))
                {
                    Console.WriteLine("False");
                    chek = false;
                    break;
                }
                if (math_exp[i] == '(')
                {
                    if (math_exp[i + 1] == '+' || math_exp[i + 1] == '-' || math_exp[i + 1] == '*' || math_exp[i + 1] == '/')
                    {
                        if (math_exp[i + 1] == '-')
                        {
                            if (math_exp[i + 2] >= '0' || math_exp[i + 2] <= '9')
                            {
                                count++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("False");
                            chek = false;
                            break;
                        }
                    }
                    else
                        if (count1 > 0)
                        {
                            if (math_exp[i - 1] == '+' || math_exp[i - 1] == '-' || math_exp[i - 1] == '*' ||
                                math_exp[i - 1] == '/' || math_exp[i - 1] == '(')
                            {
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("False");
                                chek = false;
                                break;
                            }
                        }
                        else if (count1 == 0)
                        {
                            count++;
                        }
                }
                if (math_exp[i] == ')')
                {
                    if (math_exp[i - 1] == '+' || math_exp[i - 1] == '-' || math_exp[i - 1] == '*' || math_exp[i - 1] == '/' ||
                        math_exp[i - 1] == '(')
                    {
                        Console.WriteLine("False");
                        chek = false;
                        break;
                    }
                    else if (math_exp[i + 1] == '+' || math_exp[i + 1] == '-' || math_exp[i + 1] == '*' ||
                        math_exp[i + 1] == '/' || math_exp[i + 1] == ')' || math_exp.EndsWith(" "))
                    {
                        count--;
                    }
                    else
                    {
                        Console.WriteLine("False");
                        chek = false;
                        break;
                    }
                }
                count1++;
            }
            if (count == 0)
            {
                if (chek == true)
                {
                    Console.WriteLine("True");
                }
            }
            else
            {
                if (chek == true)
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}