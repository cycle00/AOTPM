using System;
using System.Collections.Generic;
using System.Text;

namespace AOTPM.Commands
{
    public static class CommandListener
    {
        public static string Command = string.Empty;
        public static bool readyToListenToCommands = false;

        public static void Listen()
        {
            if (readyToListenToCommands)
            {
                Command = Console.ReadLine();
            }
        }
    }
}
