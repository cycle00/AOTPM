using System;
using System.Collections.Generic;
using System.Text;
using AOTPM.Story.Utils;
using AOTPM.Commands;

namespace AOTPM.Utils
{
    public class MoveHandler
    {
        public static Action<IPath> currentPath;

        public void MoveToNextPath(IPath currentPath)
        {
            CommandListener.readyToListenToCommands = false;

            foreach (IPath path in currentPath.subpaths)
            {
                if (path.KeyWord == CommandListener.Command)
                {
                    // move to next path
                    break;
                }
            }
        }
    }
}
