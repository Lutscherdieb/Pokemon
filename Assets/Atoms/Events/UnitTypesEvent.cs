using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `UnitTypes`. Inherits from `AtomEvent&lt;UnitTypes&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/UnitTypes", fileName = "UnitTypesEvent")]
    public sealed class UnitTypesEvent : AtomEvent<UnitTypes>
    {
    }
}
