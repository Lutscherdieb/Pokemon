using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `SkillPair`. Inherits from `AtomEventInstancer&lt;SkillPair, SkillPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SkillPair Event Instancer")]
    public class SkillPairEventInstancer : AtomEventInstancer<SkillPair, SkillPairEvent> { }
}
