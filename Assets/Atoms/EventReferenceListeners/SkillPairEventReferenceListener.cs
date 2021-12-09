using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SkillPair`. Inherits from `AtomEventReferenceListener&lt;SkillPair, SkillPairEvent, SkillPairEventReference, SkillPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SkillPair Event Reference Listener")]
    public sealed class SkillPairEventReferenceListener : AtomEventReferenceListener<
        SkillPair,
        SkillPairEvent,
        SkillPairEventReference,
        SkillPairUnityEvent>
    { }
}
