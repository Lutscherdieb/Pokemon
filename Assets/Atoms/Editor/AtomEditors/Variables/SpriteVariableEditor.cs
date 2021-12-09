using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Sprite`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SpriteVariable))]
    public sealed class SpriteVariableEditor : AtomVariableEditor<Sprite, SpritePair> { }
}
