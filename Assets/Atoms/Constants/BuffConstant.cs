using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Constant of type `Buff`. Inherits from `AtomBaseVariable&lt;Buff&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Buff", fileName = "BuffConstant")]
    public sealed class BuffConstant : AtomBaseVariable<Buff> { }
}
