using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Unit`. Inherits from `AtomVariableInstancer&lt;UnitVariable, UnitPair, Unit, UnitEvent, UnitPairEvent, UnitUnitFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Unit Variable Instancer")]
    public class UnitVariableInstancer : AtomVariableInstancer<
        UnitVariable,
        UnitPair,
        Unit,
        UnitEvent,
        UnitPairEvent,
        UnitUnitFunction>
    { }
}
