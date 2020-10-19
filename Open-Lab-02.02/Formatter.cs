using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)

        {
            string back = null;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Round(numbers[i], 2, MidpointRounding.AwayFromZero);
                back = back + numbers[i].ToString() + " ";

            }
            Console.Write(back.Replace(",", ".").TrimEnd());
        }






    }
}
