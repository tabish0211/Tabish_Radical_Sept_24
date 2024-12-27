//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tabish_Radical_Sept_24
//{
//    //internal class Generics
//    //{
//    //    static void Main()
//    //    {
//    //        MathCalculations<long> obj = new MathCalculations<long>();
//    //        Console.WriteLine(obj.GetSum(1,2));
//    //        Console.ReadLine();
//    //    }
//    //}

//    //class MathCalculations<T>
//    //{

//    //    T x, y;

//    //    public T GetSum(T p, T q)
//    //    {
//    //        this.x = p;
//    //        this.y = q;
//    //        return this.x;

//    //    }

//    //    //public long GetSum(long p, long q)
//    //    //{
//    //    //    this.a = p;
//    //    //    this.b = q;
//    //    //    return this.a + this.b;

//    //    //}


//    //    //public int GetSum(float p, float q)
//    //    //{
//    //    //    this.x = p;
//    //    //    this.y = q;
//    //    //    return this.x + this.y;

//    //    //}

//    //    //public int GetSum(double  p, double q)
//    //    //{
//    //    //    this.x = p;
//    //    //    this.y = q;
//    //    //    return this.x + this.y;

//    //    //}

//    //    //public int GetSum(string p, string q)
//    //    //{
//    //    //    this.x = p;
//    //    //    this.y = q;
//    //    //    return this.x + this.y;

//    //    //}
//    //}


//    //class Program
//    //{
//    //    static void Main()
//    //    {
//    //        GenericClass<int> intInstance = new GenericClass<int>();
//    //        intInstance.SetData(42);
//    //        Console.WriteLine(intInstance.GetData()); // Output: 42

//    //        GenericClass<string> stringInstance = new GenericClass<string>();
//    //        stringInstance.SetData("Hello");
//    //        Console.WriteLine(stringInstance.GetData()); // Output: Hello

//    //        Console.ReadLine();
//    //    }
//    //}
//    //public class GenericClass<T>
//    //{
//    //    private T data;

//    //    public void SetData(T value)
//    //    {
//    //        data = value;
//    //    }

//    //    public T GetData()
//    //    {
//    //        return data;
//    //    }
//    //}

//    //public class GenericMethodExample
//    //{
//    //    public void Display<T>(T value)
//    //    {
//    //        Console.WriteLine($"Value: {value}, Type: {value.GetType()}");
//    //    }

//    //    public void Show()
//    //    {
//    //        Console.WriteLine("Hey, I 'm a non generic method");

//    //    }
//    //}

//    //class Program
//    //{
//    //    static void Main()
//    //    {
//    //        GenericMethodExample example = new GenericMethodExample();
//    //        example.Display(100); // Output: Value: 100, Type: System.Int32
//    //        example.Display("C# Generics");// Output: Value: C# Generics, Type: System.String
//    //        example.Show();
//    //    }
//    //}

//    public interface IRepository<T>
//    {
//        void Add(T item);
//        T Get(int id);
//    }

//    public class Repository<T> : IRepository<T>
//    {
//        private Dictionary<int, T> dataStore = new Dictionary<int, T>();

//        public void Add(T item)
//        {
//            dataStore[dataStore.Count] = item;
//        }

//        public T Get(int id)
//        {
//            return dataStore.ContainsKey(id) ? dataStore[id] : default;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            IRepository<int> stringRepo = new Repository<int>();
//            stringRepo.Add(2);
//            Console.WriteLine(stringRepo.Get(0)); // Output: Item1
//        }
//    }

//    //public class GenericConstraintExample<T> where T : class, new()
//    //{
//    //    public T CreateInstance()
//    //    {
//    //        return new T();
//    //    }
//    //}

//    //class Program
//    //{
//    //    static void Main()
//    //    {
//    //        GenericConstraintExample<StringBuilder> example = new GenericConstraintExample<StringBuilder>();
//    //        StringBuilder sb = example.CreateInstance();
//    //        sb.Append("Hello, Generics!");
//    //        Console.WriteLine(sb.ToString()); // Output: Hello, Generics!
//    //    }
//    //}

//}
