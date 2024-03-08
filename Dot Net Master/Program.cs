using Dot_Net_Master;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // Boxing 

        //int num = 23; // 23 will assign to num

        //object Obj = num; // Boxing 

        //int j = (int)Obj; // UnBoxing - Convert referance type to value type

        //Console.WriteLine(num.GetType);
        //Console.WriteLine(Obj.GetType);
        //Console.WriteLine(j.GetType);

        //StringBuilder stringBuilder = new StringBuilder("Kavinda");

        //stringBuilder.Append("Buddhika");
        //stringBuilder.Append("Bandara");
        //stringBuilder.Insert(7,"Bandara");
        //stringBuilder.Replace("Bandara","Shaku");

        //Console.WriteLine(stringBuilder);

        //try
        //{
        //    throw new Exception();
        //}
        //catch (Exception e)
        //{

        //    Console.WriteLine(e);
        //}
        //finally
        //{
        //    Console.WriteLine("All process over");
        //}

        //var square = (int num) => num * num;
        //int num = 5;
        //int result = square(num);
        //Console.WriteLine($"Square is: {result}");

        //Console.ReadLine();


        //int x = 5;

        //Console.WriteLine(x);

        //TestPassByRef(ref x);

        //Console.WriteLine(x);

        //Console.ReadLine();

        //Computed computed = new Computed("Kavinda","Bandara");
       
        //Console.WriteLine(computed.FullName);

        foreach (int evenNumber in GenerateEvenNumbers())
        {
            if (evenNumber >50)
            {
                break;
            }

            Console.WriteLine(evenNumber);
        }


       


    }

    public static int TestPassByRef(ref int x)
    {
        x= x * x;
        return x;
    }

    public static IEnumerable<int> GenerateEvenNumbers()
    {
        int number = 0;
        while (true)
        {
            yield return number;
            number += 2;
        }
    }
}
