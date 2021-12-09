using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Sprite`. Inherits from `SetVariableValue&lt;Sprite, SpritePair, SpriteVariable, SpriteConstant, SpriteReference, SpriteEvent, SpritePairEvent, SpriteVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Sprite", fileName = "SetSpriteVariableValue")]
    public sealed class SetSpriteVariableValue : SetVariableValue<
        Sprite,
        SpritePair,
        SpriteVariable,
        SpriteConstant,
        SpriteReference,
        SpriteEvent,
        SpritePairEvent,
        SpriteSpriteFunction,
        SpriteVariableInstancer>
    { }
}
