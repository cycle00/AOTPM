using System.Collections.Generic;

namespace AOTPM.Story.Utils 
{
    public interface IPath 
    {
        IList<IPath> subpaths { get; }

        IPath parent { get; }

        PathTypes PathType { get; }

        int NumOfSubPaths { get; }

        string Message { get; }

        string KeyWord { get; }
        
        void Event();
    }
}