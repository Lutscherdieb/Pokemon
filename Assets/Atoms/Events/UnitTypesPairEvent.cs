using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `UnitTypesPair`. Inherits from `AtomEvent&lt;UnitTypesPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/UnitTypesPair", fileName = "UnitTypesPairEvent")]
    public sealed class UnitTypesPairEvent : AtomEvent<UnitTypesPair>
    {
    }
}
