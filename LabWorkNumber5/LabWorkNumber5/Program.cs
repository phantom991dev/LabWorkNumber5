using System;

namespace LabWorkNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Z;

            int extent_X, x1, x2, i;

            bool Stop = true;

            int number;

            i = 1;

            Z = (2 / (1.0 * 3.0));

            extent_X = 1;

            x1 = 2;

            x2 = 4;

            Console.Write("Введите X -  ");

            X = Convert.ToSingle(Console.ReadLine());

            do

            {

                if (i % 2 == 0)

                {

                    Z += Math.Pow(X, extent_X) / (x1 * x2);

                    extent_X += 1;

                    x1 += 1;

                    x2 += 1;

                }

                else

                {

                    Z -= Math.Pow(X, extent_X) / (x1 * x2);

                    extent_X += 1;

                    x1 += 1;

                    x2 += 1;

                }

                Console.WriteLine("Ответ: {0:F3}", Z);

                i++;

                Console.WriteLine("Введите для продолжения любое число, для выхода 0:");

                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)

                    break;

            } while (Stop);

        }
    }
    }
