using UnityEngine;
using UnityEngine.Events;

namespace Detection.DetectionController.GroundCollisionDetection.GroundCollisionDetectionBase
{
    public abstract class GroundCollisionDetectionControllerBase : MonoBehaviour
    {
        public abstract UnityEvent<bool> OnGroundCollisionDetected { get; }
        public abstract bool IsGrounded { get; protected set; }
        [SerializeField]
        protected LayerMask hitMask;

    }
}