using CollisionDetection.GroundCollisionDetection.Interface;
using UnityEngine;
using UnityEngine.Events;

namespace CollisionDetection.GroundCollisionDetection.BaseImplementation
{
    public abstract class GroundCollisionDetectionBase : MonoBehaviour, IGroundCollisionDetection
    {
        [SerializeField]
        protected LayerMask hitMask;
        [SerializeField]
        private UnityEvent<bool> onCollisionDetected;

        public UnityEvent<bool> OnGroundCollisionDetectedEvent => onCollisionDetected;
        public bool IsGrounded {
            get
            {
               return isGrounded;
            }
            set
            {
                isGrounded = value;
                OnGroundCollisionDetected(value);
            }
        }
        public abstract void DetectCollision();

        protected virtual void OnGroundCollisionDetected(bool isGrounded)
        {
            OnGroundCollisionDetectedEvent.Invoke(isGrounded);
        }
        
        private bool isGrounded;
    }
}