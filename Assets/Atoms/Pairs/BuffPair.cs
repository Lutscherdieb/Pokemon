using System;
using UnityEngine;
using Lutscherdieb.Pokemon;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Buff&gt;`. Inherits from `IPair&lt;Buff&gt;`.
    /// </summary>
    [Serializable]
    public struct BuffPair : IPair<Buff>
    {
        public Buff Item1 { get => _item1; set => _item1 = value; }
        public Buff Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Buff _item1;
        [SerializeField]
        private Buff _item2;

        public void Deconstruct(out Buff item1, out Buff item2) { item1 = Item1; item2 = Item2; }
    }
}