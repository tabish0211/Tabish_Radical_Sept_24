using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.Design_Patterns.Creational
{
    public interface ILogger
    {
        void Log(string message);

    }
    public class Singleton : ILogger
    {
        private static Singleton _instance;

        private Singleton()
        {
            
        }
        public void Log(string message)
        {
            //we are implementing logging
        }

        public static ILogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    public class SingletonTest
    {
        //public static void Main()
        //{
        //    ILogger singleton = Singleton.GetInstance();
        //    ILogger singleton1 = Singleton.GetInstance();
        //    singleton.Log("Hello World");
        //    singleton1.Log("Hello World");
        //}

    }
       

}
