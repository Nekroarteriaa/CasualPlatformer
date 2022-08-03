using Collisions.Interface.RaycastCollisionDetection;

namespace Collisions.Interface.GroundRaycastCollisionDetection
{
    public interface IGroundRaycasterRaycastCollisionDetection: IRaycastCollisionDetection
    {
        bool IsGrounded { get; }
       
    }

}