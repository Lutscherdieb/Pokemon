using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Buff`. Inherits from `AtomEvent&lt;Buff&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Buff", fileName = "BuffEvent")]
    public sealed class BuffEvent : AtomEvent<Buff>
    {
    }
}
