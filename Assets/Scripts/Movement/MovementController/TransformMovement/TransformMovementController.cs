using Movement.Behaviour.TransformMovement;
using Movement.Interface;
using NoCallbackVariables.Vector3Variable;
using UnityEngine;

namespace Movement.MovementController.TransformMovement
{
    public class TransformMovementController : MonoBehaviour
    {
        [SerializeField]
        private Vector3NoCallbackVariable movementVector3Variable;
        
        [SerializeField]
        float moveSpeed;
        
        private IMovement movementBehaviour;
        private void Awake()
        {
            movementBehaviour = new TransformMovementBehaviour(transform);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(movementVector3Variable == null) return;
            movementBehaviour.Move( movementVector3Variable.Value * (Time.deltaTime * moveSpeed));
        }
    }
}

