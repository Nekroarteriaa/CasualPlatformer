using Jump.Interface;
using UnityEngine;

namespace Jump.Behaviour.Rigibody2DWallJumpBehaviour
{
    public class Rigibody2DWallJumpBehaviour : IWallJump
    {
        private Rigidbody2D rigidbody2D;

        public Rigibody2DWallJumpBehaviour(Rigidbody2D rigidbody2D)
        {
            this.rigidbody2D = rigidbody2D;
        }


        public void DoWallJump(Vector3 direction, float impulse)
        {
            rigidbody2D.velocity =  direction * impulse;
          // rigidbody2D.AddForce(direction * impulse);
        }
    }
}