using Damage.Behaviour.DamageDealer;
using Damage.Interface.DamageDealer;
using UnityEngine;

namespace Damage.Controller.DamageDealerBase
{
    public abstract class DamageDealerControllerBase : MonoBehaviour
    {
        [SerializeField] 
        protected int damageToApply;
        protected IDamageDealer damageDealerBehaviour;

        protected virtual void Awake()
        {
            damageDealerBehaviour = new DamageDealerBehaviour();
        }
    }
}