using Movement.Interface;
using UnityEngine;

namespace Movement.Behaviour.TransformMovement
{
    public class TransformMovementBehaviour : IMovement
    {
        private Transform currentTransfrom;

        public TransformMovementBehaviour(Transform currentTransfrom)
        {
            this.currentTransfrom = currentTransfrom;
        }

        public void Move(Vector3 direction)
        {
            currentTransfrom.position += direction;
        }
    }
}

