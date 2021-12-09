using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Sprite`. Inherits from `AtomEventReference&lt;Sprite, SpriteVariable, SpriteEvent, SpriteVariableInstancer, SpriteEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpriteEventReference : AtomEventReference<
        Sprite,
        SpriteVariable,
        SpriteEvent,
        SpriteVariableInstancer,
        SpriteEventInstancer>, IGetEvent 
    { }
}
