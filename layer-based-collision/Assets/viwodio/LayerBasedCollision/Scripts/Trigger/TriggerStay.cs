using UnityEngine;

namespace viwodio.LayerBasedCollision
{
    public class TriggerStay : TriggerBase
    {
        private void OnTriggerStay(Collider other)
        {
            if (ValidateCollision(other.gameObject))
            {
                OnTrigger?.Invoke(other);
            }
        }
    }
}