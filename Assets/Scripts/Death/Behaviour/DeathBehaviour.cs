using Kill.Interface;
using UnityEngine;

namespace Death.Behaviour
{
    public class DeathBehaviour : MonoBehaviour , IDeath
    {
        public void DoDie()
        {
            Destroy(gameObject);
        }
    }
}