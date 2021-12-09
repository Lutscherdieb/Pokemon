using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `UnitPair`. Inherits from `AtomEvent&lt;UnitPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/UnitPair", fileName = "UnitPairEvent")]
    public sealed class UnitPairEvent : AtomEvent<UnitPair>
    {
    }
}
