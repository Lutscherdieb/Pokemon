using System;
using UnityEngine.Events;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Buff`. Inherits from `UnityEvent&lt;Buff&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BuffUnityEvent : UnityEvent<Buff> { }
}
