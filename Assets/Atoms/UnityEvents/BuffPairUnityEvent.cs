using System;
using UnityEngine.Events;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `BuffPair`. Inherits from `UnityEvent&lt;BuffPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BuffPairUnityEvent : UnityEvent<BuffPair> { }
}
