using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int answer;

            Console.WriteLine("Здравствуйте! Это маетиматический тест, в котором Вам необходимо будет вводить номер правильного варианта ответа.");

            Console.WriteLine();
            Console.WriteLine("Вопрос 1(решите пример):");
            Console.WriteLine("(36 + 15) * 2 = ...");
            Console.WriteLine("Варианты ответов:");
            Console.WriteLine("1. 102 \n2. 94 \n3. 116 \n4. 103");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Верно!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Не верно, правильный ответ 1.");
            }

            Console.WriteLine();
            Console.WriteLine("Вопрос 2(решите уравнение):");
            Console.WriteLine("8x - 15.3 = 6x - 3.3 | x = ...");
            Console.WriteLine("Варианты ответов:");
            Console.WriteLine("1. 7 \n2. 4 \n3. 6 \n4. 1,4");
            answer = int.Parse(Console.ReadLine());
            if (answer == 3)
            {
                Console.WriteLine("Верно!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Не верно, правильный ответ 3.");
            }

            Console.WriteLine();
            Console.WriteLine("Вопрос 3(упростите выражение):");
            Console.WriteLine("-2(3x - 2y) - 5(2y - 3x)");
            Console.WriteLine("Варианты ответов:");
            Console.WriteLine("1. 6y-9x \n2. 9x-6y \n3. -6x+9y \n4. -9x-6y");
            answer = int.Parse(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("Верно!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Не верно, правильный ответ 2.");
            }

            Console.WriteLine();
            Console.WriteLine("Вопрос 4:");
            Console.WriteLine("Какое выражение является наибольшим?");
            Console.WriteLine("Варианты ответов:");
            Console.WriteLine("1. 3√5 \n2. 2√11 \n3. 2√10 \n4. 6,5");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Верно!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Не верно, правильный ответ 1.");
            }

            Console.WriteLine();
            Console.WriteLine("Вопрос 5:");
            Console.WriteLine("Какое из следующих чисел заключено между 17/19 и 13/14?");
            Console.WriteLine("Варианты ответов:");
            Console.WriteLine("1. 0,6 \n2. 0,7 \n3. 0,8 \n4. 0,9");
            answer = int.Parse(Console.ReadLine());
            if (answer == 4)
            {
                Console.WriteLine("Верно!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Не верно, правильный ответ 4.");
            }

            Console.WriteLine();
            Console.WriteLine("Результаты:");
            if(score < 3)
            {
                Console.WriteLine("Вы не прошли данный тест.");
            }
            else
            {
                Console.WriteLine("Вы прошли математический тест");
            }
            Console.WriteLine($"Кол-во правильных ответов: {score}");
            Console.ReadKey();
        }
    }
}
