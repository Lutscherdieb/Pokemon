using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Unit to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Unit Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncUnitVariableInstancerToCollection : SyncVariableInstancerToCollection<Unit, UnitVariable, UnitVariableInstancer> { }
}
