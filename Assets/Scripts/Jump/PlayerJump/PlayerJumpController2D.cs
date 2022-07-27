using CollisionDetection.GroundCollisionDetection.BaseImplementation;
using CollisionDetection.GroundCollisionDetection.GroundCollisionDetectionManager;
using Jump.Rigidbody2DImplementation;
using Jump.Interface;
using UnityEngine;

namespace Jump.PlayerJump
{
    public class PlayerJumpController2D : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D rigidbody2D;

        [SerializeField] 
        private GroundCollisionDetectorDetectorManager groundCollisionDetectionBase;

        [SerializeField] [Range(0f,1f)] 
        private float jumpRecoil;

        [SerializeField] 
        private float jumpImpulse;

        private IJump playerJump;
        private float nextJump;
        
        private void Awake()
        {
            playerJump = new JumpBehaviourRigidbody2D(rigidbody2D);
            
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.Space) && groundCollisionDetectionBase.IsGrounded && Time.time > nextJump)
            {
                playerJump.Jump(jumpImpulse);
                nextJump = Time.time + jumpRecoil;
            }
            
            
        }
    }
}