using System;
using UnityEngine.Events;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `SkillPair`. Inherits from `UnityEvent&lt;SkillPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SkillPairUnityEvent : UnityEvent<SkillPair> { }
}
