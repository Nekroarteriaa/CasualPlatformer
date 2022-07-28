using Movement.Implementation;
using Movement.Interface;
using Impulses.BaseImplementation.MovementImpulse;
using UnityEngine;

namespace Movement.PlayerMovement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Rigidbody2DMovementController : MonoBehaviour
    {
        [SerializeField] 
        private MovementImpulseBase movementImpulseBase;
        
        [SerializeField] 
        private Rigidbody2D rigidbody2D;
        
        [SerializeField]
        float moveSpeed;
        
        private Vector3 movementDirection;
        private IMovement movementBehaviour;
        private void Awake()
        {
            movementBehaviour = new Rigidbody2DMovementBehaviour(rigidbody2D);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            movementDirection = movementImpulseBase.MovementDirection;
            movementBehaviour.Move( movementDirection  * Time.deltaTime * moveSpeed);
        }
    }
}