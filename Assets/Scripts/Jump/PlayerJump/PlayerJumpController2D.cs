using CollisionDetection.GroundCollisionDetection.BaseImplementation;
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
        private GroundCollisionDetectionBase groundCollisionDetectionBase;

        [SerializeField] 
        private float jumpImpulse;
        private IJump playerJump;
        
        private void Awake()
        {
            playerJump = new JumpBehaviourRigidbody2D(rigidbody2D);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(Input.GetKeyDown(KeyCode.Space) && groundCollisionDetectionBase.IsGrounded)
                playerJump.Jump(jumpImpulse);
        }
    }
}