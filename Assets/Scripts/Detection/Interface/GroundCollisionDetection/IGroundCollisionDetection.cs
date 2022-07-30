using Detection.Interface.CollisionDetection;

namespace Detection.Interface.GroundCollisionDetection
{
    public interface IGroundCollisionDetection: ICollisionDetection
    {
        
        bool IsGrounded { get; }
       
    }

}