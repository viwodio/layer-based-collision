using System;
using UnityEngine;
using UnityEngine.Events;

namespace viwodio.LayerBasedCollision
{
    public class CollisionBase : BaseBehaviour
    {
        public CollisionEvent OnCollision;

        [Serializable]
        public class CollisionEvent : UnityEvent<Collision> { };
    }
}