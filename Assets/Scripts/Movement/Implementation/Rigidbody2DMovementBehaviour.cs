using Movement.Interface;
using UnityEngine;

namespace Movement.Implementation
{
    public class Rigidbody2DMovementBehaviour : IMovement
    {
        private Rigidbody2D currentRigidbody2D;

        public Rigidbody2DMovementBehaviour(Rigidbody2D currentRigidbody2D)
        {
            this.currentRigidbody2D = currentRigidbody2D;
        }

        public void Move(Vector3 direction)
        {
            currentRigidbody2D.MovePosition(currentRigidbody2D.transform.position + direction);
        }
    }
}