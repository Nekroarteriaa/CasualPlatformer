using System;
using Damage.Behaviour.DamageDealer;
using UnityEngine;

namespace Damage.Controller.DamageDealerBase
{
    public abstract class DamageDealerControllerBase : MonoBehaviour
    {
        [SerializeField] 
        protected int damageToApply;
        protected DamageDealerBehaviour damageDealerBehaviour;

        private void Awake()
        {
            damageDealerBehaviour = new DamageDealerBehaviour();
        }
    }
}