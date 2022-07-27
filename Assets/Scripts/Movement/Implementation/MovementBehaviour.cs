using Movement.Interface;
using UnityEngine;

namespace Movement.Implementation
{
    public class MovementBehaviour : IMovement
    {
        private Transform currentTransfrom;

        public MovementBehaviour(Transform currentTransfrom)
        {
            this.currentTransfrom = currentTransfrom;
        }

        public void Move(Vector3 direction)
        {
            currentTransfrom.position += direction;
        }
    }
}

