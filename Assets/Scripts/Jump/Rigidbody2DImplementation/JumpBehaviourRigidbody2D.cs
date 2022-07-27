using Jump.BaseImplementation;
using UnityEngine;

namespace Jump.Rigidbody2DImplementation
{
    public class JumpBehaviourRigidbody2D : JumpBehaviourBase
    {
        private Rigidbody2D rigidbody2D;

        public JumpBehaviourRigidbody2D(Rigidbody2D rigidbody2D)
        {
            this.rigidbody2D = rigidbody2D;
        }

        public override void Jump(float impulse)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, impulse);
        }
    }
}