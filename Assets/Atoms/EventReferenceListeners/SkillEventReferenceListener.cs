using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Skill`. Inherits from `AtomEventReferenceListener&lt;Skill, SkillEvent, SkillEventReference, SkillUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Skill Event Reference Listener")]
    public sealed class SkillEventReferenceListener : AtomEventReferenceListener<
        Skill,
        SkillEvent,
        SkillEventReference,
        SkillUnityEvent>
    { }
}
