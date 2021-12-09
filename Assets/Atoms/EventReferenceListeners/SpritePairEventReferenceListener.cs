using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SpritePair`. Inherits from `AtomEventReferenceListener&lt;SpritePair, SpritePairEvent, SpritePairEventReference, SpritePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SpritePair Event Reference Listener")]
    public sealed class SpritePairEventReferenceListener : AtomEventReferenceListener<
        SpritePair,
        SpritePairEvent,
        SpritePairEventReference,
        SpritePairUnityEvent>
    { }
}
