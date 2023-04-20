using System;
using System.Diagnostics.CodeAnalysis;

namespace Array_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.İstifadəçidən string qəbul edən və sonra string’i sözlər array’inə ayıran
            //proqram yaradın. Sonra array’dəki sözlərin sayını çıxarın.

            //Console.WriteLine("Enter you text");
            //string input = Console.ReadLine();
            //string[] word = input.Split(' ');
            //int wordCount = word.Length;
            //Console.WriteLine(wordCount);



            //2.Tam ədədlər array’i yaradan və sonra elementlərin cəmini hesablayan
            //proqram yazın.

            //int[] nums = { 220, 1, 5, 9, 2, 12, 92, 29, 0 };
            //    int sum = nums.Sum();
            //    Console.WriteLine(sum);



            //3.İstifadəçidən cümlə qəbul edən və sonra hər sözün ilk hərfini böyük hərflə
            //yazan proqram yaradın. Sonra dəyişdirilmiş cümləni ekrana çıxarın.


            //Console.WriteLine("Enter you sentences: ");
            //string sentence = Console.ReadLine();
            //string[] array = sentence.Split(' ');
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = array[i].Substring(0,1 ).ToUpper() + array[i].Substring(0);

            //}
            //string result = string.Join(' ', array);
            //Console.WriteLine(result);



            //4.İstifadəçidən string ədəd qəbul edən və dəyərindən asılı olaraq sətri
            //integer və ya double tipinə çevirən proqram yazin.


            //Console.WriteLine("Enter your words");
            //string words =Console.ReadLine();
            //int.Parse(words);
            //Console.WriteLine(words);



            //5.İstifadəçidən vergüllə ayrılmış ədəd siyahısını qəbul edən proqram
            //yaradın.Daha sonra daxil edilən ədədləri string array’inə və hər bir
            //elementi tam ədədə çevirmək üçün Split() metodundan istifadə edin.
            //Nəhayət, tam ədədlərin ədədi ortasını hesablayın və nəticəni çıxarın.

            double sum = 0;
            Console.Write("Enter you numbers: ");
            string numbers = Console.ReadLine();
            string[] splitNumbers = numbers.Split(',');
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                double.TryParse(splitNumbers[i], out double value);
                sum += value;
            }
            Console.WriteLine(sum/splitNumbers.Length);


           


            



        }
    }
}
