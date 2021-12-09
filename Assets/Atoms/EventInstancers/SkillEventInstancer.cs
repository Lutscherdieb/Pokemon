using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Skill`. Inherits from `AtomEventInstancer&lt;Skill, SkillEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Skill Event Instancer")]
    public class SkillEventInstancer : AtomEventInstancer<Skill, SkillEvent> { }
}
