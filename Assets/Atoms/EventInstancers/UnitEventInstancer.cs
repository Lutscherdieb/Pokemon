using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Unit`. Inherits from `AtomEventInstancer&lt;Unit, UnitEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Unit Event Instancer")]
    public class UnitEventInstancer : AtomEventInstancer<Unit, UnitEvent> { }
}
