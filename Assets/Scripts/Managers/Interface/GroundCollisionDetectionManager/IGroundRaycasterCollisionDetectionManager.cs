using Collisions.Interface.RaycastCollisionDetection;

namespace Managers.Interface.GroundCollisionDetectionManager
{
    public interface IGroundRaycastCollisionDetectionManager : IRaycastCollisionDetection
    {
        bool IsGrounded { get; set; }
    }
}