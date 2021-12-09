using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnitTypes`. Inherits from `AtomEventReferenceListener&lt;UnitTypes, UnitTypesEvent, UnitTypesEventReference, UnitTypesUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/UnitTypes Event Reference Listener")]
    public sealed class UnitTypesEventReferenceListener : AtomEventReferenceListener<
        UnitTypes,
        UnitTypesEvent,
        UnitTypesEventReference,
        UnitTypesUnityEvent>
    { }
}
