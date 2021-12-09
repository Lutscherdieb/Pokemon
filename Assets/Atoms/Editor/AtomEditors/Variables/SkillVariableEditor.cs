using UnityEditor;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Skill`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SkillVariable))]
    public sealed class SkillVariableEditor : AtomVariableEditor<Skill, SkillPair> { }
}
