using UnityEngine;

namespace viwodio.LayerBasedCollision
{
    public class TriggerExit : TriggerBase
    {
        private void OnTriggerExit(Collider other)
        {
            if (ValidateCollision(other.gameObject))
            {
                OnTrigger?.Invoke(other);
            }
        }
    }
}