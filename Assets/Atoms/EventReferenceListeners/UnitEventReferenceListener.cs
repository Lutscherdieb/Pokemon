using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Unit`. Inherits from `AtomEventReferenceListener&lt;Unit, UnitEvent, UnitEventReference, UnitUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Unit Event Reference Listener")]
    public sealed class UnitEventReferenceListener : AtomEventReferenceListener<
        Unit,
        UnitEvent,
        UnitEventReference,
        UnitUnityEvent>
    { }
}
