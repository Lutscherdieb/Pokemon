using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Buff`. Inherits from `SetVariableValue&lt;Buff, BuffPair, BuffVariable, BuffConstant, BuffReference, BuffEvent, BuffPairEvent, BuffVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Buff", fileName = "SetBuffVariableValue")]
    public sealed class SetBuffVariableValue : SetVariableValue<
        Buff,
        BuffPair,
        BuffVariable,
        BuffConstant,
        BuffReference,
        BuffEvent,
        BuffPairEvent,
        BuffBuffFunction,
        BuffVariableInstancer>
    { }
}
