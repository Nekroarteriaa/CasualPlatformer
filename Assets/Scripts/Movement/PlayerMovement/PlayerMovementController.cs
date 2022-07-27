using Movement.Implementation;
using Movement.Interface;
using UnityEngine;

namespace Movement.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField]
        float moveSpeed;

        private string horizontal = "Horizontal";
        private string vertical = "Vertical";
        private Vector3 movementDirection;
        private IMovement playerMovementBehaviour;

        private void Awake()
        {
            playerMovementBehaviour = new MovementBehaviour(transform);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            movementDirection.x = Input.GetAxis(horizontal);
            playerMovementBehaviour.Move( movementDirection  * Time.deltaTime * moveSpeed);
        }
    }
}

