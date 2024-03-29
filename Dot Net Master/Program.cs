﻿using Dot_Net_Master;
using System.Security.Cryptography.X509Certificates;
using System.Text;


internal class Program
{
    private static volatile bool _shouldTerminate = false;
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


        int x = 5;

        Console.WriteLine(x);

        TestPassByRef(ref x);

        Console.WriteLine(x);

        Console.ReadLine();

        //Computed computed = new Computed("Kavinda","Bandara");

        //Console.WriteLine(computed.FullName);

        //foreach (int evenNumber in GenerateEvenNumbers())
        //{
        //    if (evenNumber >50)
        //    {
        //        break;
        //    }

        //    Console.WriteLine(evenNumber);
        //}


        //Thread workerthread = new Thread(Worker);
        //workerthread.Start();

        //Console.ReadLine();
        //_shouldTerminate = true;
        //workerthread.Join(); 

        //var Person = GetPersonInfo();
        //Console.WriteLine($"Name : {Person.Item1}, Age : {Person.Item2}");
        //Console.ReadLine();

        //var newValue = GetPerson();

        //var sum = CalculateSum([10, 20, 30, 40]);
        //Console.WriteLine(sum);

        //DisplayMethod displayMethod = delegate (string message)
        //{
        //    Console.WriteLine(message);
        //};

        //displayMethod("Check Delegate");

        //Complex_Number a = new Complex_Number(3,2);
        //Complex_Number b = new Complex_Number(1,4);

        //Complex_Number sum = a + b;

        //Dog dog = new Dog(6);
        //dog.MakeSound();

        //List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9 };

        //IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

        //IEnumerable<int> evenNumberQ = (from x in numbers
        //                                where x % 2 == 0
        //                                select x).ToList();
        //foreach (int number in evenNumbers)
        //{
        //    Console.WriteLine(number);
        //}

        //int[] array = { 10, 20, 30 , 40};

        //int result1 = TestParams.Sum(10,20,30,40);
        //int result2 = TestParams.Sum();

        //Console.WriteLine(result1);
        //Console.WriteLine(result2);


        //int result = StaticClass.Add(10,20);

        //Console.WriteLine(result);

        //MyDelegate myDelegate = MyClass.
        //myDelegate("Hello World");

        //Cat cat = new Cat();
        //cat.Speak();

        //IAnimal animal = new Dos();
        ////animal.Speak();
        //Test01 test01 = new Test01(animal);
        //test01.TestDog();

        //Console.ReadLine();

        //try
        //{
        //    throw new NotImplementedException();
        //}
        //catch (Exception ex)
        //{
        //    throw new Exception("Modified exception message", ex);

        //}

        //Nullable<int> MyNullable = null;
        //int? MyInt = null;
        //int? MyInt1 = 5;

        //if (string.IsNullOrEmpty(MyInt.ToString()))
        //{
        //    Console.WriteLine("Yes");
        //}

        //var y = MyInt.GetValueOrDefault(1);

        //Console.WriteLine(MyInt.HasValue);

        //Console.WriteLine(y);

        //int b = MyInt ?? 10;


        //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

        //IEnumerable<int> QuerySyn = (from x in numbers
        //                             where x % 2 == 0
        //                             select x).ToList();

        //foreach (var item in QuerySyn)
        //{
        //    Console.WriteLine(item);
        //}


        //var MethodSyn = numbers.Where(x => x % 2 == 0).ToList();
        //foreach (var item in MethodSyn)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.ReadLine();



        //string myName = "Kavinda";

        //myName = "Banadara";

        //Console.WriteLine(myName);


        //int x = 5;
        //x = 10;

        //Console.WriteLine(x);


        //Person person01 = new Person();
        //person01.Name = "Kavinda";
        //Console.WriteLine(person01.Name);
        //Console.WriteLine();

        //Person person02 = person01; //Both nperson 1 and person 2 reference the same object in memory
        //Console.WriteLine(person01.Name);
        //Console.WriteLine(person02.Name);
        //Console.WriteLine();

        //person02.Name = "Shaku";
        //Console.WriteLine(person01.Name);
        //Console.WriteLine(person02.Name);

        //Person person01 = new Person();
        //Person person02 = new Person("Shakuni",29);





        //try
        //{
        //    throw new CustomException("This is Custome");
        //}
        //catch (CustomException ex)
        //{

        //    Console.WriteLine("Caught a Custome Exception : " + ex.Message);
        //}



        //Person person01 = new Person();
        







        //Console.ReadLine();
    }
    public partial class MyClass
    {

    }

    public partial class MyClass
    {

    }
    public static int TestPassByRef(ref int x)
    {
        x = x * x;
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

    public static void Worker()
    {
        int counter = 0;

        while (!_shouldTerminate)
        {
            counter++;

        }

        Console.WriteLine("Terminated after {0} iterations.", counter);
    }


    public static Tuple<int, string> GetPersonInfo()
    {
        int age = 30;
        string name = "Jhone";

        return Tuple.Create(age, name);
    }

    public static (int Age, string name) GetPerson()
    {
        int age = 30;
        string name = "Jhone";

        return (age, name);
    }

    public static int CalculateSum(int[] numbers)
    {
        //Local function

        int Add(int a, int b)
        {
            return a + b;
        }

        int sum = 0;

        foreach (var number in numbers)
        {
            sum = Add(sum, number);
        }
        return sum;
    }

    public delegate void DisplayMethod(string message);

    public async Task<string> DownloadCountAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            var content = await client.GetStringAsync(url);
            return content;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Kavinda";
            Age = 29;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            Console.WriteLine($"your name : {name} and your age : {age}");
        }



        public int Number;

        public int number
        {
            get { return number; }
            set { number = value; }
        }

        public int[] items = new int[5];

        public int this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }

        }

        public const double Pi = 3.14;
    }


    public class GenericsList<T>
    {
        public GenericsList()
        {

        }
    }

    public abstract class AbscClass
    {
        public abstract void Count();

        public void MyCount()
        {

        }
    }
}

    
