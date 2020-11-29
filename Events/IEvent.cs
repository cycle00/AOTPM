using System;

namespace AOTPM.Events 
{
    public interface IEvent 
    {
        string Definition { get; }

        void Event();
    }
}