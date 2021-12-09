using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Buff`. Inherits from `AtomEventReferenceListener&lt;Buff, BuffEvent, BuffEventReference, BuffUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Buff Event Reference Listener")]
    public sealed class BuffEventReferenceListener : AtomEventReferenceListener<
        Buff,
        BuffEvent,
        BuffEventReference,
        BuffUnityEvent>
    { }
}
