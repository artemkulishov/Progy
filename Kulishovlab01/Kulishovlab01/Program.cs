using System;

namespace Kulishovlab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //тут хз че твориться
            Console.WriteLine("Задание 1: Напишите программу, чтобы найти значение указанного выражения");
            int a = (1 + 10) / 3;
            Console.WriteLine(a);
            double b = Math.Pow(10, + 10) * 1;
            Console.WriteLine(b);
            bool c = true && true;
            Console.WriteLine(c);
            bool d = false && true;
            Console.WriteLine(d);
            bool e = (false && false) && (false && true);
            Console.WriteLine(e);
            bool f = (false && false) && (true && true);
            Console.WriteLine(f);

            Console.WriteLine("Задание 2: Напишите программу, которая принимает четыре целых числа от пользователя и выводит надпись равно, если все четыре равны, и не равно в противном случае");
            int firstNum, secondNum, thirdNum, fourthNum;
            Console.WriteLine("Напишите 4 числа");
            //получаем строку и коныертируем в число 
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());
            thirdNum = Convert.ToInt32(Console.ReadLine());
            fourthNum = Convert.ToInt32(Console.ReadLine());

            //сравниваем числа, если они все равно, то пишем равно
            if (firstNum == secondNum && firstNum == thirdNum && firstNum == fourthNum)
            {
                Console.WriteLine("равно");
            }
            else
            {
                Console.WriteLine("не равно");
            }

            Console.WriteLine("Задание 3: Напишите программу для поиска k самых больших элементов в заданном массиве. Элементы в массиве могут располагаться в любом порядке.");

            //создаем маассив
            int[] arrInt = new int[random.Next(1, 100 + 1)];

            //заполняем массив
            for (int i = 0; i < arrInt.Length; i++)
            {               //рандомное число от 1 до 100
                arrInt[i] = random.Next(1, 100 + 1);
            }
            //сортируем массив от меньшего к большему
            Sort(arrInt);

            Console.WriteLine("Введите к");
            int k = Convert.ToInt32(Console.ReadLine());

            //определяем сколько элементов надо вывести

            int k1 = arrInt.Length - k;
            //выводим значения после К
            for (int i = arrInt.Length - 1; i > k1 - 1; i--)
            {
                Console.Write(arrInt[i] + " ");
            }


            Console.WriteLine();
            Console.WriteLine("Задание 4: Напишите программу для поиска k наименьших элементов в заданном массиве. Элементы в массиве могут располагаться в любом порядке.");

            //выводим значения массива до К
            for (int i = 0; i < k; i++)
            {
                Console.Write(arrInt[i] + " ");
            }

            Console.WriteLine("Задание 5: Напишите программу для поиска чисел, превышающих среднее значение чисел данного массива.");

            //создаем масссив
            int[] arrIntTAsk5 = new int[random.Next(1, 100 + 1)];
            int numOverAveTask5 = 0;
            double aveTask5;

            //заполняем массив и считаем сумму всех чисел массива
            for (int i = 0; i < arrIntTAsk5.Length; i++)
            {
                arrIntTAsk5[i] = random.Next(1, 100 + 1);
                numOverAveTask5 += arrIntTAsk5[i];
            }

            //выводим массив
            foreach (int i in arrIntTAsk5)
            {
                Console.Write(i + " ");
            }

            //считаем среднее массивы разделив сумму всех чисел на количество элементов
            aveTask5 = numOverAveTask5 / arrIntTAsk5.Length;

            Console.WriteLine("\n" + aveTask5 + "\n");

            //выводим элементы массивы, которые болльше среднего массива
            foreach (int i in arrIntTAsk5)
            {
                if (i > aveTask5)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Задание 6: Напишите программу для умножения двух заданных целых чисел без использования оператора умножения(*).");
            Console.WriteLine("Введите целое первое число");
            //получаем первое число
            int firstNumTask6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое второе число");
            //получаем второе число
            int secondNumTask6 = Convert.ToInt32(Console.ReadLine());
            int resultTask6 = 0;
            //складываем первое число столько раз, чему равно второе число 
            for (int i = 0; i < secondNumTask6; i++)
            {
                resultTask6 += firstNumTask6;
            }
            //выводим результат
            Console.WriteLine(resultTask6);


            Console.WriteLine("Задание 7: Напишите для разбиения заданного массива целых чисел на четное число первым и нечетное число вторым.");
            //создаем первый массив
            int[] firstArr = new int[arrInt.Length];
            //создаем второй массив
            int[] secondArr = new int[arrInt.Length];

            //заполняем первый и второй массив
            for (int i = 0; i < arrInt.Length; i++)
            {
                double a7 = arrInt[i] % 2;
                //если элемент массива arrInt не делиться на два без остатка, то записываем этот элемент в первый массив, а если нет, то во второй
                if (a7 != 0)
                {
                    firstArr[i] = arrInt[i];
                }
                else
                {
                    secondArr[i] = arrInt[i];
                }
            }
            
            //выводим первые первый массив
            Console.WriteLine("Не чётные ==");
            foreach (int i in firstArr)
            {
                if (i != 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();

            //выводим второй массив
            Console.WriteLine("Чётные ==");
            foreach (int i in secondArr)
            {
                if (i != 0)
                {
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine("Задание 8: Напишите програмиу для преобразования температуры из градуса Фаренгейта в градус Цельсия.");
            Console.WriteLine("Напишите температуру в Фаренгейтах");

            //получаем строку с фаренгейтами и переводим строку в число
            double far = Convert.ToDouble(Console.ReadLine());

            //по формуле считаем цельсии 
            double celsiusc = (far - 32) * 5 / 9;
            //выводим итог
            Console.WriteLine("C = {0}", celsiusc);

            Console.WriteLine("Задание 9: Напишите программу для вычисления индекса массы тела (ИМТ). ИМТ = ВЕС / РОСТ2");
            Console.WriteLine("Напишите вес тела");
            //получаем строку с весом тела и конвертируем в число
            double a9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напишите рост в  метрах");
            //получаем строку с ростом и конвертируем в число
            double b9 = Convert.ToDouble(Console.ReadLine());
            //по формуле считаем имт
            double c9 = a9 / b9;
            //выводим ответ
            Console.WriteLine(c9 + "= имт");

            Console.WriteLine("Задание 10: Напишите программу, которая считывает число и отображает квадрат, куб и четвертую степень. ");
            Console.WriteLine("Напишите число");
            //получем строку с числом и конвертируем ее в число
            int numTask10 = Convert.ToInt32(Console.ReadLine());
            //возводим в квадрат
            double  numSqu= Math.Pow(numTask10, 2);
            //выводим результат
            Console.WriteLine(numSqu);
            //возводим в куб
            double numCube = Math.Pow(numTask10, 3);
            //выводим результат
            Console.WriteLine(numCube);
            //возводим в четвертую степень
            double num4degree = Math.Pow(numTask10, 4);
            //выводим результат
            Console.WriteLine(num4degree);

            Console.WriteLine("Задание 11: Напишите программу, чтобы проверить, могут ли три заданные длины сторон (целые числа) образовать треугольник или нет.");
            Console.WriteLine("Напишите 3 стороны");

            //получаем числы
            int firstSide= Convert.ToInt32(Console.ReadLine());
            int secondSide = Convert.ToInt32(Console.ReadLine());
            int thirdSide = Convert.ToInt32(Console.ReadLine());
            //сравниваем суммы
            if (firstSide + secondSide > thirdSide || firstSide + thirdSide > secondSide || thirdSide + secondSide > firstSide)
            {
                Console.WriteLine("могут");
            }
            else
            {
                Console.WriteLine("не могут");
            }


          
        }


        //метод сортировки массива (хз как он написан)
        static void Sort(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
