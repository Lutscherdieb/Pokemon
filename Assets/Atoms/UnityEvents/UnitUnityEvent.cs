using System;
using UnityEngine.Events;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Unit`. Inherits from `UnityEvent&lt;Unit&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UnitUnityEvent : UnityEvent<Unit> { }
}
