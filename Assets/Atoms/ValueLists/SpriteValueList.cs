using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Sprite`. Inherits from `AtomValueList&lt;Sprite, SpriteEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Sprite", fileName = "SpriteValueList")]
    public sealed class SpriteValueList : AtomValueList<Sprite, SpriteEvent> { }
}
