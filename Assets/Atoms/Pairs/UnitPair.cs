using System;
using UnityEngine;
using Lutscherdieb.Pokemon;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Unit&gt;`. Inherits from `IPair&lt;Unit&gt;`.
    /// </summary>
    [Serializable]
    public struct UnitPair : IPair<Unit>
    {
        public Unit Item1 { get => _item1; set => _item1 = value; }
        public Unit Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Unit _item1;
        [SerializeField]
        private Unit _item2;

        public void Deconstruct(out Unit item1, out Unit item2) { item1 = Item1; item2 = Item2; }
    }
}