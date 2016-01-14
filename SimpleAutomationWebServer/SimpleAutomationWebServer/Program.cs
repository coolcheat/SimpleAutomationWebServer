using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bend.Util;
using System.Threading;
using System.Runtime.InteropServices;

namespace SimpleAutomationWebServer
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;


        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();
            if (args.Length > 0)
            {
                if(args[0].Equals("debug")){
                    ShowWindow(handle, SW_SHOW);  // show the console window for debug purposes
                }
                else
                {
                    ShowWindow(handle, SW_HIDE);  // hdie the console
                }
            }
            else
            {
                ShowWindow(handle, SW_HIDE);  // hide the console
            }


            HttpServer httpServer;

            httpServer = new MyHttpServer(8090);

            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();
            //var handle = GetConsoleWindow();
            // Hide
            //ShowWindow(handle, SW_HIDE);

            // Show
            //ShowWindow(handle, SW_SHOW);


        }
    }
}
