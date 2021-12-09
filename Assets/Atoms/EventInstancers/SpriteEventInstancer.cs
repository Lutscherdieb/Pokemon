using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Sprite`. Inherits from `AtomEventInstancer&lt;Sprite, SpriteEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Sprite Event Instancer")]
    public class SpriteEventInstancer : AtomEventInstancer<Sprite, SpriteEvent> { }
}
