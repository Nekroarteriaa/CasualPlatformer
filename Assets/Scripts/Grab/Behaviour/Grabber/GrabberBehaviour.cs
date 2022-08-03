using Grab.Interface.Grabbable;
using Grab.Interface.Grabber;

namespace Grab.Behaviour.Grabber
{
    public class GrabberBehaviour : IGrabber
    {
        public void Grab(IGrabbable grabbable)
        {
            grabbable.Grabbed();
        }
    }
}