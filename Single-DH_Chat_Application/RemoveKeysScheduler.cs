using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace EncryptedChatApplication
{
    public class RemoveKeysScheduler : IHostedService, IDisposable
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();
        private int executionCount = 0;
        private readonly ILogger<RemoveKeysScheduler> _logger;
        private Timer _timer;

        public RemoveKeysScheduler(ILogger<RemoveKeysScheduler> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(RemoveKeysFunction, null, TimeSpan.Zero,
                TimeSpan.FromHours(24));

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        private void RemoveKeysFunction(object state)
        {
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            StreamReader MyStreamReader = new StreamReader("Path to a text file that stores the count ...");
            StreamWriter MyStreamWriter = new StreamWriter("Path to a text file that stores the count ...");
            String CountString = "";
            int Count = 0;
            MySqlCommand MySQLNonQuery = new MySqlCommand();
            MySqlCommand MySQLNonQuery2 = new MySqlCommand();
            CountString = MyStreamReader.ReadLine();
            if (CountString.CompareTo("") != 0 && CountString != null)
            {
                Count = int.Parse(CountString);
                if (Count == 30)
                {
                    MySQLNonQuery.CommandText = "DELETE FROM `Chat_Message`";
                    MySQLNonQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLNonQuery.Prepare();
                    MySQLNonQuery.ExecuteNonQuery();
                    MySQLNonQuery2.CommandText = "DELETE FROM `DF_Public_Key`";
                    MySQLNonQuery2.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLNonQuery2.Prepare();
                    MySQLNonQuery2.ExecuteNonQuery();
                    MyStreamWriter.WriteLine("");
                    _logger.LogInformation("Respective data and count has been reset....");
                }
                else 
                {
                    Count += 1;
                    MyStreamWriter.WriteLine(Count.ToString());
                }
            }
            else 
            {
                Count = 1;
                MyStreamWriter.WriteLine(Count.ToString());
            }


            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
