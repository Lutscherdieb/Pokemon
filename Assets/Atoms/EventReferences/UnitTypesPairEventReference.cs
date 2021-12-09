using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `UnitTypesPair`. Inherits from `AtomEventReference&lt;UnitTypesPair, UnitTypesVariable, UnitTypesPairEvent, UnitTypesVariableInstancer, UnitTypesPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UnitTypesPairEventReference : AtomEventReference<
        UnitTypesPair,
        UnitTypesVariable,
        UnitTypesPairEvent,
        UnitTypesVariableInstancer,
        UnitTypesPairEventInstancer>, IGetEvent 
    { }
}
