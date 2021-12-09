using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Unit`. Inherits from `AtomEventReference&lt;Unit, UnitVariable, UnitEvent, UnitVariableInstancer, UnitEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UnitEventReference : AtomEventReference<
        Unit,
        UnitVariable,
        UnitEvent,
        UnitVariableInstancer,
        UnitEventInstancer>, IGetEvent 
    { }
}
