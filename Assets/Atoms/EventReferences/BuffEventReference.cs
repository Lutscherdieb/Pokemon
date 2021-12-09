using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Buff`. Inherits from `AtomEventReference&lt;Buff, BuffVariable, BuffEvent, BuffVariableInstancer, BuffEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BuffEventReference : AtomEventReference<
        Buff,
        BuffVariable,
        BuffEvent,
        BuffVariableInstancer,
        BuffEventInstancer>, IGetEvent 
    { }
}
