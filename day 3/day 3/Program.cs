using System;

namespace day_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 1; //счетчик
            while(counter!=20) //оглашение условия
            {
                counter++;
                Console.WriteLine($"Hello World! {counter}");
                
                if (counter == 10)
                {
                    break; // позволяет завершить цикл досрочно, то есть війти из цікла
                }
            }
            Console.WriteLine(" -----------------------------");

            do
            {
                Console.WriteLine($"Hello World! from second cycle {counter}");
                counter++;
            }
            while (false);
            Console.WriteLine(" {-----------------------------");

            //цыклы ФОР в своем оглашении сразу оглашают счетчик, условие завершения, операцию которая будет выполняться в каждую итерацию цыкла
            //в данном случае операция будет от нуля до 10 раз будет выводить что это И-тая операция цикла фор
            //int i =0 - переменная счетчика; i < 10 - словие выполнения;i++ - операция над нашим счетчиком которая будет выпоолняться каждую итерацию нашего цыкла
            for (int i =0; i < 10; i++)   // можно сделать от 5 до нуля  for (int i = 5; i < 10; i--)
            {
                Console.WriteLine($" {i} --th operation from for");
            }
            Console.WriteLine(" {-----------------------------");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue; // пропустим 5 шаг, то есть позволяет пропустить итерацию
                Console.WriteLine($" {i} --th operation from for");
            }
            Console.WriteLine(" {-----------------------------");

            for (int i = 10; i>0;i-=2)
            {
                if (i == 5)
                    continue; // пропустим 5 шаг, то есть позволяет пропустить итерацию
                Console.WriteLine($" {i} --th operation from for");
            }
            Console.WriteLine(" {-----------------------------");



            string mystring = "mystring"; // строка это набор символов или еще называют коллекцией символов
            for (int i = 0; i < mystring.Length; i++)
            {

                //[i] - это индексатор. штука позволяющая обратиться к определенному элименту определенной строки
                Console.WriteLine(mystring[i]);
                Console.WriteLine($" Char at positiom {i} = " + mystring[i]);
            }
            Console.WriteLine(" -----------------------------");

            //для того чтобы проходить по коллекциям можно использльзовать брата цыкла for - ЦЫКЛ foreach

            foreach ( char letter in mystring) // синтаксис делится на до ИН и после ИН. После ИН - по какой коллекции надо идтию Перед Ин - переменная которая представляет каждый отдельный символ в строке и назвали мы его леттер
            // в данном цыкле не видно в явном виде итерации - но они есть
            {
                Console.WriteLine(letter);
                
            }

                int height = 100;
                int width = 50;
                Console.SetWindowSize(height, width);


        }
    }
}
