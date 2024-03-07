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

        StringBuilder stringBuilder = new StringBuilder("Kavinda");

        stringBuilder.Append("Buddhika");
        stringBuilder.Append("Bandara");
        stringBuilder.Insert(7,"Bandara");
        stringBuilder.Replace("Bandara","Shaku");

        Console.WriteLine(stringBuilder);





        Console.ReadLine();
    }
}
