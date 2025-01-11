using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24
{
    internal class AsyncAwaitDemo
    {
        //class SyncCaller
        //{
        //    static void Main()
        //    {
        //        //Synchronous call
        //        var synchrnousObj = new Synchronous();
        //        var watch = new System.Diagnostics.Stopwatch();
        //        watch.Start();
        //        synchrnousObj.GetSqlDataSource();//9
        //        synchrnousObj.GetMySQLDataSource();//9
        //        synchrnousObj.GetOracleDataSource();//9
        //        watch.Stop();
        //        Console.WriteLine($"Total in ms :{watch.ElapsedMilliseconds}");
        //        Console.ReadLine();

        //    }
        //}
        //class Synchronous
        //{
        //    //public void GetSqlDataSource()
        //    //{
        //    //    GetSQlData();
        //    //}

        //    //public void GetMySQLDataSource()
        //    //{
        //    //    GetMySQlData();
        //    //}

        //    //public void GetOracleDataSource()
        //    //{
        //    //    GetOracleData();
        //    //}

        //    //private static SQLDataSource GetSQlData()
        //    //{
        //    //    Console.WriteLine("Getting Data from SQL");
        //    //    Task.Delay(9000).Wait();
        //    //    Console.WriteLine("Sql Data is finished");
        //    //    return new SQLDataSource();
        //    //}

        //    //private static MySqlDataSource GetMySQlData()
        //    //{

        //    //    Console.WriteLine("Getting Data from MY SQL");
        //    //    Task.Delay(9000).Wait();

        //    //    Console.WriteLine("MY Sql Data is finished");
        //    //    return new MySqlDataSource();
        //    //}


        //    //private static OracleDataSource GetOracleData()
        //    //{

        //    //    Console.WriteLine("Getting Data from Oracle SQL");
        //    //    Task.Delay(9000).Wait();

        //    //    Console.WriteLine("Oracle Sql Data is finished");
        //    //    return new OracleDataSource();
        //    //}
        //} 

           

        }

    //    //private static async Task<SQLDataSource> GetSQlData()
    //    //{
    //    //    Console.WriteLine("Getting Data from SQL");
    //    //    await Task.Delay(12000);
    //    //    Console.WriteLine("Sql Data is finished");
    //    //    return new SQLDataSource();
    //    //}

    //    //private static async Task<MySqlDataSource> GetMySQlData()
    //    //{

    //    //    Console.WriteLine("Getting Data from MY SQL");
    //    //    await Task.Delay(10000);

    //    //    Console.WriteLine("MY Sql Data is finished");
    //    //    return new MySqlDataSource();
    //    //}


    //    //private static async Task<OracleDataSource> GetOracleData()
    //    //{

    //    //    Console.WriteLine("Getting Data from Oracle SQL");
    //    //    await Task.Delay(14000);

    //    //    Console.WriteLine("Oracle Sql Data is finished");
    //    //    return new OracleDataSource();
    //    //}
    //}

    class AsynSyncCaller
    {
        static async Task Main()
        {
            //ASynchronous call
            var asynchrnousObj = new AsyncSynchronous();
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Task task1 = asynchrnousObj.GetSqlDataSourceAsync();
            Task task2 = asynchrnousObj.GetMySQLDataSourceAsync();
            Task task3 = asynchrnousObj.GetOracleDataSourceAsync();

            List<Task> tasks = new List<Task>() { task1, task2, task3 };
            while (tasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(tasks);
                if (finishedTask == task1)
                {
                    Console.WriteLine("Record fetched from SQL Data Source");
                }
                else if (finishedTask == task2)
                {
                    Console.WriteLine("Record fetched from My SQL Data Source");
                }
                else if (finishedTask == task3)
                {
                    Console.WriteLine("Record fetched from Oracle SQL Data Source");
                }

                await finishedTask;
                tasks.Remove(finishedTask);

            }
            Console.WriteLine($"Total in ms :{watch.ElapsedMilliseconds}");
            Console.ReadLine();

        }
    }
    class AsyncSynchronous
    {
        public async Task GetSqlDataSourceAsync()
        {
            await GetSQlDataAsync();
        }

        public async Task GetMySQLDataSourceAsync()
        {
            await GetMySQlDataAsync();
        }

        public async Task GetOracleDataSourceAsync()
        {
            await GetOracleDataAsync();
        }


        private static async Task<SQLDataSource> GetSQlDataAsync()
        {
            Console.WriteLine("Getting Data from SQL");
            await Task.Delay(12000);
            Console.WriteLine("Sql Data is finished");
            return new SQLDataSource();
        }

        private static async Task<MySqlDataSource> GetMySQlDataAsync()
        {

            Console.WriteLine("Getting Data from MY SQL");
            await Task.Delay(10000);

            Console.WriteLine("MY Sql Data is finished");
            return new MySqlDataSource();
        }


        private static async Task<OracleDataSource> GetOracleDataAsync()
        {

            Console.WriteLine("Getting Data from Oracle SQL");
            await Task.Delay(14000);

            Console.WriteLine("Oracle Sql Data is finished");
            return new OracleDataSource();
        }
    }

    class SQLDataSource
    {
    }

    class OracleDataSource
    {
    }

    class MySqlDataSource
    {
    }



}

