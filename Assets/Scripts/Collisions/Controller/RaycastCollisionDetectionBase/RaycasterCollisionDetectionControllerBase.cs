using Collisions.Interface.RaycastCollisionDetection;
using UnityEngine;
using UnityEngine.Events;

namespace Collisions.Controller.RaycastCollisionDetectionBase
{
    public abstract class RaycasterCollisionDetectionControllerBase : MonoBehaviour
    {
        public abstract UnityEvent<bool> OnCollisionDetected { get; }
        public abstract bool HasBeenHitted { get; protected set; }
        public abstract Vector3 HittedNormalPoint { get; protected set; }
        [SerializeField]
        protected LayerMask hitMask;
        
        protected IRaycastCollisionDetection RaycastCollisionDetection;

    }
}