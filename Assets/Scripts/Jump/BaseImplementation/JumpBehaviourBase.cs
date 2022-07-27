using Jump.Interface;
using UnityEngine;

namespace Jump.BaseImplementation
{
    public abstract class JumpBehaviourBase : IJump 
    {
        public abstract void Jump(float impulse);
    }
    
}