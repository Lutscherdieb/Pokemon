using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `UnitTypes`. Inherits from `AtomEventReference&lt;UnitTypes, UnitTypesVariable, UnitTypesEvent, UnitTypesVariableInstancer, UnitTypesEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UnitTypesEventReference : AtomEventReference<
        UnitTypes,
        UnitTypesVariable,
        UnitTypesEvent,
        UnitTypesVariableInstancer,
        UnitTypesEventInstancer>, IGetEvent 
    { }
}
