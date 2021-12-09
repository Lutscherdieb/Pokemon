using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `UnitTypes`. Inherits from `AtomValueList&lt;UnitTypes, UnitTypesEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/UnitTypes", fileName = "UnitTypesValueList")]
    public sealed class UnitTypesValueList : AtomValueList<UnitTypes, UnitTypesEvent> { }
}
