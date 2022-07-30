using NoCallbackVariables.Interface;
using UnityEngine;

namespace NoCallbackVariables.Base
{
    public abstract class NoCallbackVariablesBase<T> : ScriptableObject, INoCallbackVariables<T>
    {
        public abstract T Value { get; set; }
        [SerializeField] 
        protected T value;
    }
}