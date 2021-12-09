using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnitTypesPair`. Inherits from `AtomEventReferenceListener&lt;UnitTypesPair, UnitTypesPairEvent, UnitTypesPairEventReference, UnitTypesPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/UnitTypesPair Event Reference Listener")]
    public sealed class UnitTypesPairEventReferenceListener : AtomEventReferenceListener<
        UnitTypesPair,
        UnitTypesPairEvent,
        UnitTypesPairEventReference,
        UnitTypesPairUnityEvent>
    { }
}
