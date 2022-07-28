using Impulses.BaseImplementation.MovementImpulse;
using UnityEngine;
using UnityEngine.Events;

namespace Impulses.InputImplementation.InputMovementImplementation
{
    public class HorizontalInputMovementImpulseFixedUpdate : MovementImpulseBase
    {
        public override Vector3  MovementDirection => movementDirection;
        public override UnityEvent<bool, Vector3> ImpulseDirection => impulseDirection;

        [SerializeField] 
        private UnityEvent<bool, Vector3> impulseDirection;
        
        private string horizontal = "Horizontal";
        private Vector3 movementDirection;
        private float previousImpulse;
        private void FixedUpdate()
        {
            movementDirection.x = Input.GetAxis(horizontal);
            
            if (movementDirection.x > 0)
            {
                if(previousImpulse > 0) return;
                impulseDirection.Invoke(true, movementDirection);
                previousImpulse = movementDirection.x;
            }
            else if(movementDirection.x < 0)
            {
                if(previousImpulse < 0) return;
                impulseDirection.Invoke(true, movementDirection);
                previousImpulse = movementDirection.x;
            }
            
            else if (movementDirection.x == 0)
            {
                if(previousImpulse == 0) return;
                impulseDirection.Invoke(false, movementDirection);
                previousImpulse = movementDirection.x;
            }
        }
    }
}