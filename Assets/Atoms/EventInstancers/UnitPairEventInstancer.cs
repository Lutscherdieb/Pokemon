using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `UnitPair`. Inherits from `AtomEventInstancer&lt;UnitPair, UnitPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/UnitPair Event Instancer")]
    public class UnitPairEventInstancer : AtomEventInstancer<UnitPair, UnitPairEvent> { }
}
