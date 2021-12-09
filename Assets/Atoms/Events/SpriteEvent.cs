using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Sprite`. Inherits from `AtomEvent&lt;Sprite&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Sprite", fileName = "SpriteEvent")]
    public sealed class SpriteEvent : AtomEvent<Sprite>
    {
    }
}
