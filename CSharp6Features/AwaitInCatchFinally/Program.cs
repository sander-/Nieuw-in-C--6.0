using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AwaitInCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadCode();
            Console.ReadLine();
        }

        static async void DownloadCode()
        {
            WebClient client = new WebClient();
            try
            {
                var address = new Uri("https://github.com/sander-/Nieuw-in-C--6.0/archive/master.zip");
                await client.DownloadFileTaskAsync(address, "c:\\temp\\code.zip");

            }
            catch (WebException e)
            {
                // Dit kon niet in =< C# 5.0
                await Logger.LogWrite(e.Message);
            }
            finally
            {
                // Dit kon niet in =< C# 5.0
                await Logger.LogWrite("Klaar.");
            }

        }
        static class Logger
        {
            public async static Task LogWrite(string message)
            {
                await Task.Run(() =>
               System.IO.File.AppendAllText("c:\\temp\\log.txt", message + Environment.NewLine));
            }
        }
    }
}
