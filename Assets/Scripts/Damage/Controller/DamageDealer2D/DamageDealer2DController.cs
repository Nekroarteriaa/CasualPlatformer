using Damage.Controller.DamageDealerBase;
using Damage.Interface.DamageReceiver;
using UnityEngine;

namespace Damage.Controller.DamageDealer2D
{
    public class DamageDealer2DController : DamageDealerControllerBase
    {
        private void OnCollisionEnter2D(Collision2D col)
        {
            col.gameObject.TryGetComponent(out IDamageReceiver damageReceiver);
            if(damageReceiver == null) return;
            damageDealerBehaviour.DealDamage(damageReceiver, damageToApply);
        }
    }
}