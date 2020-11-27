using System;

namespace AOTPM.Story.Utils {
    public abstract class Path {
        public abstract int NumOfSubPaths { get; set; }
        
        public virtual void Event() {
            Console.WriteLine("Please add an event or more.");
        }
    }
}