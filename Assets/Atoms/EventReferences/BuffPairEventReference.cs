using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `BuffPair`. Inherits from `AtomEventReference&lt;BuffPair, BuffVariable, BuffPairEvent, BuffVariableInstancer, BuffPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BuffPairEventReference : AtomEventReference<
        BuffPair,
        BuffVariable,
        BuffPairEvent,
        BuffVariableInstancer,
        BuffPairEventInstancer>, IGetEvent 
    { }
}
