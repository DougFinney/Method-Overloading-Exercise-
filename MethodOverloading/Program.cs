using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var answer = Add(8, 4);


            var x = 29;
            var a = 32.0m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1;
        }

        public static string Add(decimal num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

        

    }

}