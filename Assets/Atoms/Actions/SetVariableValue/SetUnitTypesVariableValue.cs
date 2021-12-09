using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnitTypes`. Inherits from `SetVariableValue&lt;UnitTypes, UnitTypesPair, UnitTypesVariable, UnitTypesConstant, UnitTypesReference, UnitTypesEvent, UnitTypesPairEvent, UnitTypesVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/UnitTypes", fileName = "SetUnitTypesVariableValue")]
    public sealed class SetUnitTypesVariableValue : SetVariableValue<
        UnitTypes,
        UnitTypesPair,
        UnitTypesVariable,
        UnitTypesConstant,
        UnitTypesReference,
        UnitTypesEvent,
        UnitTypesPairEvent,
        UnitTypesUnitTypesFunction,
        UnitTypesVariableInstancer>
    { }
}
