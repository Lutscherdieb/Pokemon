using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnitTypes`. Inherits from `AtomVariableInstancer&lt;UnitTypesVariable, UnitTypesPair, UnitTypes, UnitTypesEvent, UnitTypesPairEvent, UnitTypesUnitTypesFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/UnitTypes Variable Instancer")]
    public class UnitTypesVariableInstancer : AtomVariableInstancer<
        UnitTypesVariable,
        UnitTypesPair,
        UnitTypes,
        UnitTypesEvent,
        UnitTypesPairEvent,
        UnitTypesUnitTypesFunction>
    { }
}
