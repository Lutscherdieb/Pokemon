using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Buff`. Inherits from `AtomEventInstancer&lt;Buff, BuffEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Buff Event Instancer")]
    public class BuffEventInstancer : AtomEventInstancer<Buff, BuffEvent> { }
}
