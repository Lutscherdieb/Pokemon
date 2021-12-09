using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Unit`. Inherits from `SetVariableValue&lt;Unit, UnitPair, UnitVariable, UnitConstant, UnitReference, UnitEvent, UnitPairEvent, UnitVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Unit", fileName = "SetUnitVariableValue")]
    public sealed class SetUnitVariableValue : SetVariableValue<
        Unit,
        UnitPair,
        UnitVariable,
        UnitConstant,
        UnitReference,
        UnitEvent,
        UnitPairEvent,
        UnitUnitFunction,
        UnitVariableInstancer>
    { }
}
