using Movement.Implementation;
using Movement.Interface;
using Impulses.BaseImplementation.MovementImpulse;
using UnityEngine;

namespace Movement.PlayerMovement
{
    public class TransformMovementController : MonoBehaviour
    {
        [SerializeField] 
        private MovementImpulseBase movementImpulseBase;
        
        [SerializeField]
        float moveSpeed;
        
        private Vector3 movementDirection;
        private IMovement movementBehaviour;
        private void Awake()
        {
            movementBehaviour = new TransformMovementBehaviour(transform);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            movementDirection = movementImpulseBase.MovementDirection;
            movementBehaviour.Move( movementDirection  * Time.deltaTime * moveSpeed);
        }
    }
}

