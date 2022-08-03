using Impulses.Interface.MovementImpulse;
using NoCallbackVariables.Vector3Variable;
using UnityEngine;

namespace Impulses.Behaviour.InputMovementImpulse
{
    public class HorizontalInputMovementImpulseFixedUpdateBehaviour : MonoBehaviour, IMovementImpulse
    {
        public Vector3  MovementDirection => movementDirection;
        [SerializeField] 
        private Vector3NoCallbackVariable movementVector3Variable;
        private string horizontal = "Horizontal";
        private Vector3 movementDirection;
        private void FixedUpdate()
        {
            movementDirection.x = Input.GetAxis(horizontal);
            if(movementVector3Variable == null) return;
            movementVector3Variable.Value = movementDirection;

        }
    }
}