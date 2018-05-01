using System;
using System.Data.SqlClient;
using System.Data;
using System.Threading;


namespace deadLock
{
    class Program
    {
        static void firstRun()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RED181G\\OANASQL; Initial Catalog = NBAChampionship; Integrated Security = true");
            conn.Open();
            try
            {
                SqlTransaction tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("deadLock1", conn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                tran.Commit();
                Console.WriteLine("first transaction commited");
            }catch(SqlException e)
            {   //have been chosen as a deadLock victim
                if (e.Number == 1250)
                {
                    Console.WriteLine("First transaction has been chosen as a deadLock victim - restart");
                    firstRun();
                }
            }
        }
        static void secondRun()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RED181G\\OANASQL; Initial Catalog = NBAChampionship; Integrated Security = true");
            conn.Open();
            try
            {
                SqlTransaction tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("deadLock2", conn, tran);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                tran.Commit();
                Console.WriteLine("second transaction commited");
            }
            catch (SqlException e)
            {   //have been chosen as a deadLock victim
                if (e.Number == 1250)
                {
                    Console.WriteLine("Second transaction has been chosen as a deadLock victim - restart");
                    secondRun();
                }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(firstRun));
            Thread t2 = new Thread(new ThreadStart(secondRun));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.Write("done");
            Console.ReadKey();
        }
    }
}
