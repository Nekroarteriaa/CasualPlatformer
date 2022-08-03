using Grab.Grabber.Controller.GrabberBase;
using Grab.Interface.Grabbable;
using UnityEngine;

namespace Grab.Controller.Grabber.Grabber2D
{
    public class Grabber2DController : GrabberControllerBase
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            col.gameObject.TryGetComponent(out IGrabbable grabbable);
            if(grabbable == null) return;
            grabber.Grab(grabbable);
        }
    }
}