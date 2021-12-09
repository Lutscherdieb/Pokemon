using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Skill to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Skill Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncSkillVariableInstancerToCollection : SyncVariableInstancerToCollection<Skill, SkillVariable, SkillVariableInstancer> { }
}