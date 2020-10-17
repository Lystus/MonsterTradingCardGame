using System;

namespace MonsterCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Server ...");
            // listener = new HttpListener();

            // If get an access error try the following command in a terminal with admin access
            // netsh http add urlacl url=http://+:80/ user=Everyone
            // ############ OR ############
            // us following statement for the Prefix ->
            // var basePrefix = "http://+:80/Temporary_Listen_Addresses/" + Guid.NewGuid().ToString("D") + "/";
            // var basePrefix = "http://+:80/";
            // listener.Prefixes.Add(basePrefix);

            // listener.Start();

            // Console.WriteLine($"Serve under {basePrefix}");

            // while (true)
            // {
            //     HttpListenerContext context = listener.GetContext();

            //     HttpListenerResponse response = context.Response;

            //     String message = "Test Response";

            //     byte[] buffer = Encoding.UTF8.GetBytes(message);
            //     response.ContentEncoding = Encoding.UTF8;
            //     response.ContentLength64 = buffer.Length;

            //     response.OutputStream.Write(buffer);

            //     context.Response.Close();
            // }

        }
    }
}