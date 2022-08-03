using UnityEngine.Events;

namespace Grab.Interface.Grabbable
{
    public interface IGrabbable
    {
        UnityEvent OnGrabbed { get; }
        void Grabbed();
    }
}