using Grab.Behaviour.Grabber;
using Grab.Interface.Grabber;
using UnityEngine;

namespace Grab.Grabber.Controller.GrabberBase
{
    public abstract class GrabberControllerBase : MonoBehaviour
    {
        protected IGrabber grabber;

        protected void Awake()
        {
            grabber = new GrabberBehaviour();
        }
    }
}