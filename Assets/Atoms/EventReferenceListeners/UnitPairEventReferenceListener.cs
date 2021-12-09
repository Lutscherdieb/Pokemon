using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnitPair`. Inherits from `AtomEventReferenceListener&lt;UnitPair, UnitPairEvent, UnitPairEventReference, UnitPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/UnitPair Event Reference Listener")]
    public sealed class UnitPairEventReferenceListener : AtomEventReferenceListener<
        UnitPair,
        UnitPairEvent,
        UnitPairEventReference,
        UnitPairUnityEvent>
    { }
}
