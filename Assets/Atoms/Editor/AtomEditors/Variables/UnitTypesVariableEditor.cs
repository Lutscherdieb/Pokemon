using UnityEditor;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnitTypes`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(UnitTypesVariable))]
    public sealed class UnitTypesVariableEditor : AtomVariableEditor<UnitTypes, UnitTypesPair> { }
}
