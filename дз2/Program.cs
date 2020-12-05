using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("метод, возвращающий минимальное из трех чисел.\n");

            #region Зад. 1

            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            minNumber(a, b, c);

            #endregion

            Console.Write("\nметод подсчета количества цифр числа.\n");

            #region Зад. 2

            Console.Write("Ведите число: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            numberCount(userNumber);

            #endregion

            Console.Write("\n\nС клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n");

            #region Зад. 3

            int number = 0;
            int sum = 0;
            do
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 1 && number >= 0)
                {
                    sum = sum + number;

                }

            } while (number != 0);
            Console.Write($"Сумма всех нечетных чисел равна {sum}");

            #endregion

            Console.Write("\n\nметод проверки логина и пароля.\n");

            #region Зад. 4

            var count = 0;

            do
            {
                Console.Write("Введите логин: ");
                var loginUser = Convert.ToString(Console.ReadLine());
                Console.Write("Введите пароль: ");
                var passwordUser = Convert.ToString(Console.ReadLine());
                count++;

                if (checkLP(loginUser, passwordUser))
                {
                    Console.Write("Добро пожаловать!");
                    break;
                }
                if (count == 3)
                {
                    Console.Write("Неверный логин или пароль. Попытки завершились.");
                }
                else
                {
                    Console.Write("Неверный логин или пароль. Попробуйте еще раз.\n");
                }

            } while (count < 3);

            #endregion

            Console.Write("\n\nпрограмма, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме\n");

            #region Зад. 5(а,б)

            string userGender = "";

            do
            {
                Console.Write("Введите ваш пол (м/ж): ");//проверку не забыть
                userGender = Console.ReadLine();
            } while (userGender != "м" && userGender != "ж");

            Console.Write("Введите массу тела(кг): ");
            float userWeight = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите рост(см): ");
            float userHight = Convert.ToSingle(Console.ReadLine()) / 100;

            float bmi = Convert.ToSingle(userWeight / userHight / userHight);
            Console.Write("Ваш ИМТ равен {0:0.00}\n", bmi);


            //а),б)


            if (bmi <= 16)
            {
                Console.Write("Выраженный дефицит массы тела\n");

                Console.Write("Вам надо набрать кг {0:0.00}", WeightCheck(userGender, userWeight, userHight));


            }
            else if (bmi >= 16 && bmi <= 18.5)
            {
                Console.Write("Недостаточная масса тела\n");
                Console.Write("Вам надо набрать кг {0:0.00}", WeightCheck(userGender, userWeight, userHight));
            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                Console.Write("Нормальная масса тела\n");
            }
            else if (bmi >= 25 && bmi <= 30)
            {
                Console.Write("Избыточная масса тела(предожирение)\n");
                Console.Write("Вам надо сбросить кг {0:0.00}", WeightCheck(userGender, userWeight, userHight));
            }
            else if (bmi >= 30 && bmi <= 35)
            {
                Console.Write("Ожирение 1 - ой степени\n");
                Console.Write("Вам надо сбросить кг {0:0.00}", WeightCheck(userGender, userWeight, userHight));
            }
            else if (bmi >= 35 && bmi <= 40)
            {
                Console.Write("Ожирение 2 - ой степени\n");
                Console.Write("Вам надо сбросить кг {0:0.00}", WeightCheck(userGender, userWeight, userHight));
            }
            else if (bmi >= 40)
            {
                Console.Write("Ожирение 3 - ой степени\n");
                Console.Write("Вам надо сбросить кг {0:0.00}", WeightCheck(userGender, userWeight, userHight));
            }




            #endregion

            Console.Write("\n\nрекурсивный метод, который выводит на экран числа от a до b и их сумму(a<b).\n");

            #region Зад. 7(а, б)
            int sumNum = 0;

            Console.Write("Введите число a: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Числа от a до b: ");
            Loop(num1, num2);

            Console.Write("\nСумма чисел от a до b: ");
            SumLoop(num1, num2, sumNum);

            #endregion

            Console.ReadKey();

        }

        private static float WeightCheck(string userGender, float userWeight, float userHight)
        {
            float userWeightNormal;

            if (userGender == "ж")
            {
                userWeightNormal = (userHight * 100 - 110) * 115 / 100;
                if (userWeightNormal > userWeight)
                {
                    return (userWeightNormal - userWeight);
                }
                else
                {
                    return (userWeight - userWeightNormal);
                }

            }
            else
            {
                userWeightNormal = (userHight * 100 - 100) * 115 / 100;
                if (userWeightNormal > userWeight)
                {
                    return (userWeightNormal - userWeight);
                }
                else
                {
                    return (userWeight - userWeightNormal);
                }
            }
        }


        private static void Loop(int a, int b)
        {
            Console.Write("{0,2} ", a);
            if (a < b) Loop(a + 1, b);
        }

        private static void SumLoop(int a, int b, int sumNum)
        {
            sumNum = sumNum + a;

            if (a < b)
            {
                SumLoop(a + 1, b, sumNum);
            }
            else
            {
                Console.Write(sumNum);
            }
        }

        private static void minNumber(int a, int b, int c)
        {
            Console.WriteLine(a < b && a < c ? a : b < c ? b : c);
        }

        private static void numberCount(int userNumber)
        {
            var str = userNumber.ToString();
            Console.Write($"Количесво цифр в числе {userNumber} равно {str.Length}");
        }

        private static bool checkLP(string loginUser, string passwordUser)
        {
            return loginUser == "root" && passwordUser == "GeekBrains";
        }
    }
}
