using System;
using Sys = Cosmos.System;

namespace PrismProject
{
    public class Kernel : Sys.Kernel
    {
        public static string Kernel_build = "POSL Revision 2.1";
        public static bool Running = true;
        public static bool canvasRunning = new bool();

        protected override void Run()
        {
            Console.Clear();
            Cmds.Init();
            Networking.DHCP();
            Interface.Start();
        }
    }
}