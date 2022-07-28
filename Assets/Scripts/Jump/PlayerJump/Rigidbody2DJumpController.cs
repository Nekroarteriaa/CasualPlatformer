using CollisionDetection.GroundCollisionDetection.GroundCollisionDetectionManager;
using Impulses.BaseImplementation.JumpImpulse;
using Jump.Rigidbody2DImplementation;
using Jump.Interface;
using UnityEngine;

namespace Jump.PlayerJump
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Rigidbody2DJumpController : MonoBehaviour
    {
        [SerializeField] 
        private JumpImpulseBase jumpImpulseBase;
        
        [SerializeField]
        private Rigidbody2D rigidbody2D;

        [SerializeField] 
        private GroundCollisionDetectorManager groundCollisionDetectorManager;

        [SerializeField] [Range(0f,1f)] 
        private float jumpRecoil;

        [SerializeField] 
        private float jumpImpulse;

        private IJump playerJump;
        private float nextJump;
        
        private void Awake()
        {
            playerJump = new Rigidbody2DJumpBehaviour(rigidbody2D);
            
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (jumpImpulseBase.CanJump && groundCollisionDetectorManager.IsGrounded && Time.time > nextJump)
            {
                playerJump.Jump(jumpImpulse);
                nextJump = Time.time + jumpRecoil;
            }
            
            
        }
    }
}