using System;
using System.Collections.Generic;
using AOTPM.Story.Utils;
using AOTPM.Utils;
using AOTPM.Commands;

namespace AOTPM.Story 
{
    public class Base : IPath 
    {
        public IList<IPath> subpaths => new List<IPath>();

        public IPath parent => null;
        
        public PathTypes PathType => PathTypes.START;

        public string Message => "You start off unconcious, and wake up in a mysterious cave. You see 2 paths going left and right. Where do you go?";

        public int NumOfSubPaths => 2;

        public string KeyWord => null;

        public void Event()
        {
            MoveHandler.currentPath?.Invoke(this);
            CommandListener.readyToListenToCommands = true;
        }
    }
}