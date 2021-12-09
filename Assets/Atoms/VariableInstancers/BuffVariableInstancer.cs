using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Buff`. Inherits from `AtomVariableInstancer&lt;BuffVariable, BuffPair, Buff, BuffEvent, BuffPairEvent, BuffBuffFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Buff Variable Instancer")]
    public class BuffVariableInstancer : AtomVariableInstancer<
        BuffVariable,
        BuffPair,
        Buff,
        BuffEvent,
        BuffPairEvent,
        BuffBuffFunction>
    { }
}
