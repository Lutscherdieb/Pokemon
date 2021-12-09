using System;
using UnityEngine.Events;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Skill`. Inherits from `UnityEvent&lt;Skill&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SkillUnityEvent : UnityEvent<Skill> { }
}
