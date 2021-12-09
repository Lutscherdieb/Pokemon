using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Unit`. Inherits from `AtomEvent&lt;Unit&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Unit", fileName = "UnitEvent")]
    public sealed class UnitEvent : AtomEvent<Unit>
    {
    }
}
