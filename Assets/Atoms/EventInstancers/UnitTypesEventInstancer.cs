using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `UnitTypes`. Inherits from `AtomEventInstancer&lt;UnitTypes, UnitTypesEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/UnitTypes Event Instancer")]
    public class UnitTypesEventInstancer : AtomEventInstancer<UnitTypes, UnitTypesEvent> { }
}
