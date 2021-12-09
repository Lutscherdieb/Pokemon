using UnityEditor;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Buff`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(BuffVariable))]
    public sealed class BuffVariableEditor : AtomVariableEditor<Buff, BuffPair> { }
}
