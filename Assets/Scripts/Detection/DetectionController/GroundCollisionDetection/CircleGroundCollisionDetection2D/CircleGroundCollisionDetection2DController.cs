using Detection.Behaviour.GroundCollisionDetection.CircleGroundCollisionDetection2D;
using Detection.Behaviour.GroundCollisionDetection.GroundCollisionDetectionShapes.Shapes2D.CircleCollisionDetectionShape2D;
using Detection.DetectionController.GroundCollisionDetection.GroundCollisionDetectionBase;
using Detection.Interface.GroundCollisionDetection;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Detection.DetectionController.GroundCollisionDetection.CircleGroundCollisionDetection2D
{
    public class CircleGroundCollisionDetection2DController : GroundCollisionDetectionControllerBase
    {
        public override UnityEvent<bool> OnGroundCollisionDetected => onGroundCollisionDetected;

        [SerializeField] 
        private Transform originPoint;
        [SerializeField]
        private CircleCollisionDetector circleCollisionDetector;
        [SerializeField]
        private UnityEvent<bool> onGroundCollisionDetected;
        
        private IGroundCollisionDetection groundCollisionDetection;
        

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
            groundCollisionDetection = new CircleGroundCollisionDetection2DBehaviour(originPoint, circleCollisionDetector, hitMask);
        }

        private void FixedUpdate()
        {
            groundCollisionDetection.DetectCollision();
            IsGrounded = groundCollisionDetection.IsGrounded;
        }
        
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(originPoint.position + (Vector3) circleCollisionDetector.DeltaPosition, circleCollisionDetector.CircleRadius );
        }

        
    }
}