using System;
using UnityEngine;
using UnityEngine.Events;

namespace viwodio.LayerBasedCollision
{
    public class TriggerBase : BaseBehaviour
    {
        public TriggerEvent OnTrigger;

        [Serializable]
        public class TriggerEvent : UnityEvent<Collider> { };
    }
}