using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Sprite`. Inherits from `UnityEvent&lt;Sprite&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpriteUnityEvent : UnityEvent<Sprite> { }
}
