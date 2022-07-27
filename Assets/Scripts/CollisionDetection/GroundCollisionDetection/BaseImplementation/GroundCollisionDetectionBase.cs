using CollisionDetection.GroundCollisionDetection.GroundCollisionDetectionManager;
using CollisionDetection.GroundCollisionDetection.Interface;
using UnityEngine;
using UnityEngine.Events;

namespace CollisionDetection.GroundCollisionDetection.BaseImplementation
{
    public abstract class GroundCollisionDetectionBase : GroundCollisionDetectorDetectorManager, IGroundCollisionDetectorDetection
    {
        [SerializeField]
        protected LayerMask hitMask;
        [SerializeField]
        private UnityEvent<bool> onCollisionDetected;

        public UnityEvent<bool> OnGroundCollisionDetectedEvent => onCollisionDetected;
        public override bool IsGrounded { get; set; }

        public override void DetectCollision()
        {
            
        }

        protected virtual void OnGroundCollisionDetected(bool isGrounded)
        {
            OnGroundCollisionDetectedEvent.Invoke(isGrounded);
        }
        
        protected bool isGrounded;
    }
}