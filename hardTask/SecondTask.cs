using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hardTask
{
    internal class SecondTask
    {
        public static void Second()
        {
            Console.WriteLine("1) введу сам массив\n" +
                "2) дайте готовые");
            int count = int.Parse(Console.ReadLine());

            int[] firstArray = new int[1];
            int[] secondArray = new int[1];

            switch (count)
            {
                case 1:
                    Console.WriteLine("Введите длинну массива: ");
                    int lenght = int.Parse(Console.ReadLine());
                    firstArray = new int[lenght];
                    secondArray = new int[lenght];

                    Console.WriteLine("Первый");
                    for (int i = 0; i < firstArray.Length; i++)
                    {
                        firstArray[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Второй");
                    for (int i = 0; i < secondArray.Length; i++)
                    {
                        secondArray[i] = int.Parse(Console.ReadLine());
                    }
                    break;


                case 2:

                    firstArray = new int[] { 123, 142, 125, 154, 133, 119, 148 };
                    secondArray = new int[] { 134, 142, 163, 127, 142, 155, 120 };
                    break;
            }







            int[] firstRankArray = new int[7];
            int[] secondRankArray = new int[7];

            double resultCoof = 0;


            firstRankArray = CalcIndex(firstArray, firstRankArray);
            secondRankArray = CalcIndex(secondArray, secondRankArray);

            resultCoof = CalcСoof(firstRankArray, secondRankArray);
            Console.WriteLine(resultCoof);


            int[] CalcIndex(int[] arr, int[] resultArr)
            {
                int temp = int.MinValue;
                int maxNum = int.MaxValue;
                int count = 1;

                for (int u = 0; u < arr.Length; u++)
                {
                    temp = 0;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] > temp && arr[j] < maxNum)
                            temp = arr[j];
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        maxNum = temp;
                        if (arr[i] == temp)
                        {
                            resultArr[i] = count;
                            count++;
                        }
                    }
                }
                return resultArr;
            }


            double CalcСoof(int[] firstArr, int[] secondArr)
            {
                double coofS = 0;
                double coofF = 0;

                if (firstArr.Length == secondArr.Length)
                {
                    for (int i = 0; i < secondArr.Length; i++)
                    {
                        coofS += Math.Pow((firstArr[i] - secondArr[i]), 2);
                    }

                    coofF = 1 - ((6 * coofS) / (firstArr.Length * (Math.Pow(firstArr.Length, 2) - 1)));
                    return coofF;

                }
                return 0;


            }

        }

    }
}
