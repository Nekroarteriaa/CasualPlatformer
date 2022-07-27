using CollisionDetection.InterfaceBase;

namespace CollisionDetection.GroundCollisionDetection.Interface
{
    public interface IGroundCollisionDetectorManager : ICollisionDetection
    {
        bool IsGrounded { get; set; }
    }
}