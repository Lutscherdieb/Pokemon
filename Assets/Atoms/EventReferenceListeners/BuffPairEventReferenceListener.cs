using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `BuffPair`. Inherits from `AtomEventReferenceListener&lt;BuffPair, BuffPairEvent, BuffPairEventReference, BuffPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/BuffPair Event Reference Listener")]
    public sealed class BuffPairEventReferenceListener : AtomEventReferenceListener<
        BuffPair,
        BuffPairEvent,
        BuffPairEventReference,
        BuffPairUnityEvent>
    { }
}
