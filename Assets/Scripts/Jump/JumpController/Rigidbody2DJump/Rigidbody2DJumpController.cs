using Jump.Behaviour.Rigidbody2DJump;
using Jump.Interface;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Jump.JumpController.Rigidbody2DJump
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Rigidbody2DJumpController : MonoBehaviour
    {
        [SerializeField] 
        private BoolReference jumpInputPlayerOneVariable;
        
        [SerializeField] 
        private BoolReference groundDetectionManagerVariable;
        
        [SerializeField]
        private Rigidbody2D rigidbody2D;


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
            if(jumpInputPlayerOneVariable == null || groundDetectionManagerVariable == null) return;
            if (!jumpInputPlayerOneVariable.Value || !groundDetectionManagerVariable.Value || !(Time.time > nextJump)) return;
            
            playerJump.Jump(jumpImpulse);
            nextJump = Time.time + jumpRecoil;
        }

        public void ResetVelocity()
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}