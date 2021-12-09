using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `UnitPair`. Inherits from `AtomEventReference&lt;UnitPair, UnitVariable, UnitPairEvent, UnitVariableInstancer, UnitPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UnitPairEventReference : AtomEventReference<
        UnitPair,
        UnitVariable,
        UnitPairEvent,
        UnitVariableInstancer,
        UnitPairEventInstancer>, IGetEvent 
    { }
}
