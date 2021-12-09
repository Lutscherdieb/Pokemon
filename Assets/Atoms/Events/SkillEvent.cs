using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Skill`. Inherits from `AtomEvent&lt;Skill&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Skill", fileName = "SkillEvent")]
    public sealed class SkillEvent : AtomEvent<Skill>
    {
    }
}
