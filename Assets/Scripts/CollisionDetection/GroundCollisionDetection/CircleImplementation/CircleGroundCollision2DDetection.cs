using CollisionDetection.GroundCollisionDetection.BaseImplementation;
using UnityEngine;

namespace CollisionDetection.GroundCollisionDetection.CircleImplementation
{
    public class CircleGroundCollision2DDetection : GroundCollisionDetectionBase
    {
        [SerializeField] 
        private Transform originPoint;


        [SerializeField]
        CircleCollisionDetector circleCollisionDetector;
        private RaycastHit2D hit;


        private void FixedUpdate()
        {
            DetectCollision();
        }

        public override bool IsGrounded 
        {  
            get => isGrounded;
            set
            {
                if (value == isGrounded) return;
                isGrounded = value;
                OnGroundCollisionDetected(value);

            }
            
        }

        public override void DetectCollision()
        {
            hit = Physics2D.CircleCast(originPoint.position + (Vector3)circleCollisionDetector.DeltaPosition, circleCollisionDetector.CircleRadius, Vector2.zero, circleCollisionDetector.CircleOffsetDistance ,hitMask);
            IsGrounded = (hit.collider != null) ? true : false;
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(originPoint.position + (Vector3) circleCollisionDetector.DeltaPosition, circleCollisionDetector.CircleRadius );
        }
    }
}