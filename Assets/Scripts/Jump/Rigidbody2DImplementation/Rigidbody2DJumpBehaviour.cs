using Jump.BaseImplementation;
using UnityEngine;

namespace Jump.Rigidbody2DImplementation
{
    public class Rigidbody2DJumpBehaviour : JumpBehaviourBase
    {
        private Rigidbody2D rigidbody2D;

        public Rigidbody2DJumpBehaviour(Rigidbody2D rigidbody2D)
        {
            this.rigidbody2D = rigidbody2D;
        }

        public override void Jump(float impulse)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, impulse);
        }
    }
}