using UnityEditor;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Unit`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(UnitVariable))]
    public sealed class UnitVariableEditor : AtomVariableEditor<Unit, UnitPair> { }
}
