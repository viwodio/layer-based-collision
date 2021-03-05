using viwodio.ExtensionMethods;
using UnityEngine;

namespace viwodio.LayerBasedCollision
{
    public abstract class BaseBehaviour : MonoBehaviour
    {
        [SerializeField] private LayerMask layerMask;
        public bool isActive = true;

        protected bool ValidateCollision(GameObject other)
        {
            if (!isActive) return false;
            
            return layerMask.IsSelected(other.layer);
        }

        public void AddEverythingLayer() => AddCollisionLayer("Everything");
        
        public void AddCollisionLayer(string layerName)
        {
            layerMask = LayerMask.NameToLayer(layerName);
        }
    }
}
