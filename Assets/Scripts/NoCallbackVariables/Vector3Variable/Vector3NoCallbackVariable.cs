using NoCallbackVariables.Base;
using UnityEngine;

namespace NoCallbackVariables.Vector3Variable
{
    [CreateAssetMenu(fileName = "Vector3NoCallbackVariable", menuName = "NoCallbackVariables/Vector3", order = 1)]
    public class Vector3NoCallbackVariable : NoCallbackVariablesBase<Vector3>
    {
        public override Vector3 Value { get => value; set => this.value = value; }
    }
}