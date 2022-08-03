using Collisions.Interface.GroundRaycastCollisionDetection;
using UnityEngine;
using UnityEngine.Events;

namespace Collisions.Controller.GroundCollisionDetection.GroundCollisionDetectionBase
{
    public abstract class GroundRaycasterCollisionDetectionControllerBase : MonoBehaviour
    {
        public abstract UnityEvent<bool> OnGroundCollisionDetected { get; }
        public abstract bool IsGrounded { get; protected set; }
        [SerializeField]
        protected LayerMask hitMask;
        
        protected IGroundRaycasterRaycastCollisionDetection GroundRaycasterRaycastCollisionDetection;

    }
}