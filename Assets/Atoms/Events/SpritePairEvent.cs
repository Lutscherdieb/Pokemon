using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `SpritePair`. Inherits from `AtomEvent&lt;SpritePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SpritePair", fileName = "SpritePairEvent")]
    public sealed class SpritePairEvent : AtomEvent<SpritePair>
    {
    }
}
