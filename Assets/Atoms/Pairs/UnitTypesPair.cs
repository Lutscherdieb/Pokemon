using System;
using UnityEngine;
using Lutscherdieb.Pokemon;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnitTypes&gt;`. Inherits from `IPair&lt;UnitTypes&gt;`.
    /// </summary>
    [Serializable]
    public struct UnitTypesPair : IPair<UnitTypes>
    {
        public UnitTypes Item1 { get => _item1; set => _item1 = value; }
        public UnitTypes Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnitTypes _item1;
        [SerializeField]
        private UnitTypes _item2;

        public void Deconstruct(out UnitTypes item1, out UnitTypes item2) { item1 = Item1; item2 = Item2; }
    }
}