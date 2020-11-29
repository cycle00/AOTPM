using System;
using System.Collections.Generic;
using System.Text;
using AOTPM.Story.Utils;

namespace AOTPM.Utils
{
    public class PathHandler
    {
        public IList<IPath> LoadedPaths = new List<IPath>();

        public IPath CurrentPath;
        
        public void LoadPaths()
        {
            MoveHandler.currentPath += LoadFromMove;
        }

        private void LoadFromMove(IPath path)
        {
            LoadedPaths.Add(path);
            
            if (path.NumOfSubPaths > 0)
            {
                foreach (IPath nextPath in path.subpaths)
                {
                    LoadedPaths.Add(nextPath);
                }
            }
            else
            {
                if (path.PathType != PathTypes.START)
                {
                    // Move back to parent path
                }
            }
        }
    }
}
