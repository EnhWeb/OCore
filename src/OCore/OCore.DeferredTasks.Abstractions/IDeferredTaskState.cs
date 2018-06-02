using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCore.DeferredTasks
{
    /// <summary>
    /// An implementation of this interface is responsible for storing actions that need to be executed
    /// at then end of the active request.
    /// ʵ�ִ˽ӿڴ洢��Ҫ�ӳ�ִ�еĶ�����
    /// </summary>
    public interface IDeferredTaskState
    {
        IList<Func<DeferredTaskContext, Task>> Tasks { get; }
    }
}
