using System;
using System.Threading.Tasks;

namespace OCore.DeferredTasks
{
    /// <summary>
    /// An implementation of this interface provides a way to enlist custom actions that
    /// will be executed once the request is done. Each action receives a <see cref="DeferredTaskContext"/>.
    /// Actions are executed in a new <see cref="IServiceProvider"/> scope.
    /// ѭ��ִ��ÿһ��<see cref="DeferredTaskContext"/>�������б�
    /// </summary>
    public interface IDeferredTaskEngine
    {
        /// <summary>
        /// ָʾ��ǰ�Ƿ���д�ִ�е�����
        /// </summary>
        bool HasPendingTasks { get; }

        /// <summary>
        /// ���µ�������ӵ���ִ���б�
        /// </summary>
        /// <param name="task"></param>
        void AddTask(Func<DeferredTaskContext, Task> task);
 
        /// <summary>
        /// ִ������
        /// </summary>
        /// <param name="context">Ҫִ�������������</param>
        /// <returns></returns>
        Task ExecuteTasksAsync(DeferredTaskContext context);
    }
}
