using System;
using System.Collections.Generic;
using System.Text;
using AOTPM.Story.Utils;
using AOTPM.Utils;

namespace AOTPM.Events
{
    public class Move : IEvent
    {
        public string Definition => "Moves the player to the next path.";

        public IPath nextPath;

        public void Event()
        {
            MoveHandler.currentPath?.Invoke(nextPath);
        }
    }
}
