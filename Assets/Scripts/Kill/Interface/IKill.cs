using UnityEngine.Events;

namespace Kill.Interface
{
    public interface IKill
    {
        UnityEvent OnKill { get; }
    }
}