using Detection.Interface.CollisionDetection;

namespace Managers.Interface.GroundCollisionDetectionManager
{
    public interface IGroundCollisionDetectionManager : ICollisionDetection
    {
        bool IsGrounded { get; set; }
    }
}