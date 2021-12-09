using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `UnitTypesPair`. Inherits from `AtomEventInstancer&lt;UnitTypesPair, UnitTypesPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/UnitTypesPair Event Instancer")]
    public class UnitTypesPairEventInstancer : AtomEventInstancer<UnitTypesPair, UnitTypesPairEvent> { }
}
