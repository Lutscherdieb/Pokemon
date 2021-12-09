using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `BuffPair`. Inherits from `AtomEvent&lt;BuffPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/BuffPair", fileName = "BuffPairEvent")]
    public sealed class BuffPairEvent : AtomEvent<BuffPair>
    {
    }
}
