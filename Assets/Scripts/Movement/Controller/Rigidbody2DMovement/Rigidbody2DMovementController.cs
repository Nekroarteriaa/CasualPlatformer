using Movement.Behaviour.Rigidbody2DMovement;
using Movement.Interface;
using UnityEngine;

namespace Movement.Controller.Rigidbody2DMovement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Rigidbody2DMovementController : MonoBehaviour
    {
        // [SerializeField] 
        // private ScriptableVariableVector3 movementImpulseScriptableVariable;
        
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
            // if(movementImpulseScriptableVariable == null) return;
            // movementDirection = movementImpulseScriptableVariable.Variable;
            movementBehaviour.Move( movementDirection  * Time.deltaTime * moveSpeed);
        }
    }
}