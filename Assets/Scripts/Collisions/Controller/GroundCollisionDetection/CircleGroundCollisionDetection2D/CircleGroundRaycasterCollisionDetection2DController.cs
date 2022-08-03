using Collisions.Behaviour.GroundCollisionDetection.CircleGroundCollisionDetection2D;
using Collisions.Behaviour.GroundCollisionDetection.GroundCollisionDetectionShapes.Shapes2D.CircleCollisionDetectionShape2D;
using Collisions.Controller.GroundCollisionDetection.GroundCollisionDetectionBase;
using UnityEngine;
using UnityEngine.Events;

namespace Collisions.Controller.GroundCollisionDetection.CircleGroundCollisionDetection2D
{
    public class CircleGroundRaycasterCollisionDetection2DController : GroundRaycasterCollisionDetectionControllerBase
    {
        public override UnityEvent<bool> OnGroundCollisionDetected => onGroundCollisionDetected;

        [SerializeField] 
        private Transform originPoint;
        [SerializeField]
        private CircleRaycasterCollisionDetector circleRaycasterCollisionDetector;
        [SerializeField]
        private UnityEvent<bool> onGroundCollisionDetected;
        
       
        

        public override bool IsGrounded
        {
            get => isGrounded;
            protected set
            {
                if(isGrounded == value) return;
                isGrounded = value;
                OnGroundCollisionDetected.Invoke(value);
            }
        }

        private bool isGrounded;

        private void Awake()
        {
            GroundRaycasterRaycastCollisionDetection = new CircleGroundRaycasterRaycastCollisionDetection2DBehaviour(originPoint, circleRaycasterCollisionDetector, hitMask);
        }

        private void FixedUpdate()
        {
            GroundRaycasterRaycastCollisionDetection.DetectRaycastCollision();
            IsGrounded = GroundRaycasterRaycastCollisionDetection.IsGrounded;
        }
        
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(originPoint.position + (Vector3) circleRaycasterCollisionDetector.DeltaPosition, circleRaycasterCollisionDetector.CircleRadius );
        }

        
    }
}