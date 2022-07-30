using Jump.Interface;
using UnityEngine;

namespace Jump.Behaviour.Rigidbody2DJump
{
    public class Rigidbody2DJumpBehaviour : IJump
    {
        private Rigidbody2D rigidbody2D;

        public Rigidbody2DJumpBehaviour(Rigidbody2D rigidbody2D)
        {
            this.rigidbody2D = rigidbody2D;
        }

        public void Jump(float impulse)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, impulse);
        }
    }
}