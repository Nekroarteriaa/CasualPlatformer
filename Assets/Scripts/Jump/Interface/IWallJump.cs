
using UnityEngine;

namespace Jump.Interface
{
    public interface IWallJump
    {
        void DoWallJump(Vector3 direction, float impulse);
    }
}