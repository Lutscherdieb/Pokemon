using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Buff`. Inherits from `AtomValueList&lt;Buff, BuffEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Buff", fileName = "BuffValueList")]
    public sealed class BuffValueList : AtomValueList<Buff, BuffEvent> { }
}
