internal class Program
{
    private static void Main(string[] args)
    {
        // Boxing 

        int num = 23; // 23 will assign to num

        object Obj = num; // Boxing 

        int j = (int)Obj; // UnBoxing - Convert referance type to value type

        Console.WriteLine(num.GetType);
        Console.WriteLine(Obj.GetType);
        Console.WriteLine(j.GetType);

        Console.ReadLine();
    }
}