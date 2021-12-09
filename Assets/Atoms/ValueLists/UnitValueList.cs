using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Unit`. Inherits from `AtomValueList&lt;Unit, UnitEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Unit", fileName = "UnitValueList")]
    public sealed class UnitValueList : AtomValueList<Unit, UnitEvent> { }
}
