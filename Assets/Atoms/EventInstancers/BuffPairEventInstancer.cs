using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `BuffPair`. Inherits from `AtomEventInstancer&lt;BuffPair, BuffPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/BuffPair Event Instancer")]
    public class BuffPairEventInstancer : AtomEventInstancer<BuffPair, BuffPairEvent> { }
}
