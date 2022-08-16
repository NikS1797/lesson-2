using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    internal class Program
    {
        static void min(int x, int y, int z)
        {
            int min = x < y ? (x < z ? x : z) : (y < z ? y : z);
            Console.WriteLine($"Минимальное число {min} из x={x} y={y} z={z}");
            Console.ReadLine();
            return;
        }
        static int output(long outs)
        {
            int opt = 0;
            while (outs > 0)
            {
                opt++;
                outs = outs / 10;
            }
            return opt;
        }

        static bool getAuthorization(string login, string password)
        {
            bool aut = login == "root" && password == "GeekBrains" ? true : false;
            return aut;
        }
        static bool GoodNumCheck(int counter_6)
        {
            var good = false;
            var holder = counter_6;
            var sum_6 = 0;
            var a = 0;
            do
            {
                a = counter_6 % 10;
                sum_6 = sum_6 + a;
                counter_6 = counter_6 / 10;
            } while (counter_6 >= 1);
            if (holder % sum_6 == 0) { good = true; }
            return good;
        }
        //------------------------------------------------------------------------
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.Write("Введите от 1 до 6: ");
                int cs= int.Parse(Console.ReadLine());
                switch (cs) {
                    case 1:
                        /*Латышев Никита Анаольевич*/
                        /*Написать метод, возвращающий минимальное из трёх чисел*/
                        Console.Write("x=");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("y=");
                        int y = int.Parse(Console.ReadLine());
                        Console.Write("z=");
                        int z = int.Parse(Console.ReadLine());
                        min(x, y, z);
                        Console.ReadLine();
                        break;
                   case 2:
                        /*Латышев Никита Анаольевич*/
                        /*Написать метод подсчета количества цифр числа.*/
                        Console.Write("Введите число:");
                        string str = Console.ReadLine();
                        if (long.TryParse(str, out long longOut))
                        {
                            Console.WriteLine("Количество цифр в числе {0}={1}", str, str.Length);
                            Console.WriteLine("Количество цифр в числе {0}={1}", longOut, output(longOut));
                        }
                        else Console.WriteLine("Не является числом!");
                        Console.ReadLine();
                        break;
                    case 3:
                        /*Латышев Никита Анаольевич*/
                        /*С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
положительных чисел.*/
                        int sum = 0;
                        int num;
                        do {
                            Console.Write("Введите число:");
                            num=int.Parse(Console.ReadLine());
                            sum += num > 0 && num % 2 == 1 ? num : 0;
                        } while (num != 0);
                        Console.WriteLine($"Сумма нечетных и положительных чисел =  {sum};");
                        Console.ReadLine();
                        break;
                    case 4:
                        /*Латышев Никита Анаольевич*/
                        /*Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью
цикла do while ограничить ввод пароля тремя попытками.*/
                        int i = 2;

                        Console.Write("Введите логин:");
                        string login = Console.ReadLine();
                        Console.Write("Введите пароль:");
                        string password = Console.ReadLine();
                        if (getAuthorization(login, password) == true)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2);
                            Console.Write("Вы успешно авторизовались!");
                        }
                        else
                        {
                            do
                            {
                                if (i > 0)
                                {
                                    Console.Write("Осталось попыток: " + i);
                                    Console.Write("\nВведите значение пароль:");
                                    password = Console.ReadLine();
                                    i--;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(System.Console.WindowWidth / 2 - 18, System.Console.WindowHeight / 2);
                                    Console.WriteLine("Исчерпан лимит на ввод логина/пароля");
                                    break;
                                }
                            }
                            while (getAuthorization(login, password) == false);
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        /*Латышев Никита Анаольевич*/
                        /*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса*/
                        Console.Write("\n    Интерпретация показателей ИМТ, в соответствии с ремомендациями Всемирной Организации Здравоохранения (ВОЗ):");
                        Console.Write("\n    16 и меннее     | Выраженный дефицит массы тела");
                        Console.Write("\n    16—18,5         | Недостаточная (дефицит) масса тела");
                        Console.Write("\n    18,5—25         | Норма");
                        Console.Write("\n    25—30           | Избыточная масса тела (предожирение)");
                        Console.Write("\n    30—35           | Ожирение первой степени");
                        Console.Write("\n    35—40           | Ожирение второй степени");
                        Console.Write("\n    40 и более      |   Ожирение третьей степени (морбидное)");
                        Console.Write("\nВведите рост в сантиметрах: ");
                        int hght = int.Parse(System.Console.ReadLine());
                        double height = hght / 100.0;
                        Console.Write("Введите вес в килограммах: ");
                        double weidth = double.Parse(System.Console.ReadLine());
                        double imt = weidth / (height * height);
                        string txt = "";
                        if (imt < 16) { txt = "Выраженный дефицит массы тела"; }
                        else if (imt >= 16 && imt < 18.5) { txt = "Недостаточная (дефицит) масса тела"; }
                        else if (imt >= 18.5 && imt < 25) { txt = "Норма"; }
                        else if (imt >= 25 && imt < 30) { txt = "Избыточная масса тела (предожирение)"; }
                        else if (imt >= 30 && imt < 35) { txt = "Ожирение первой степени"; }
                        else if (imt >= 35 && imt < 40) { txt = "Ожирение второй степени"; }
                        else if (imt > 40) { txt = "Ожирение третьей степени (морбидное)"; }
                        double weidthNormD = 18.5 * (height * height);
                        double weidthNormT = 25 * (height * height);
                        Console.Write("Индекс тела (ИМТ)={0:f2} – {1};\nВаш вес должен быть в пределах {2:f2}-{3:f2} килограмм;", imt, txt, weidthNormD, weidthNormT);
                        if (imt < 18.5)
                        {
                            Console.Write("\nНеобходимо набрать {0:f2} килограмм;", weidthNormD - weidth);
                        }
                        else if (imt >= 25)
                        {
                            Console.Write("\nНеобходимо сбросить {0:f2} килограмм;", weidth - weidthNormT);
                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Ответ найден в интернете, самостоятельного решения нет.");
                        
                        Console.ReadLine();
                        break;
                    default: 
                            return;

                
                }
            }

            
        }

    }
}
