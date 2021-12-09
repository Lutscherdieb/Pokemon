using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `SkillPair`. Inherits from `AtomEvent&lt;SkillPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SkillPair", fileName = "SkillPairEvent")]
    public sealed class SkillPairEvent : AtomEvent<SkillPair>
    {
    }
}
