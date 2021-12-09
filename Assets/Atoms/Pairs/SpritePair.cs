using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Sprite&gt;`. Inherits from `IPair&lt;Sprite&gt;`.
    /// </summary>
    [Serializable]
    public struct SpritePair : IPair<Sprite>
    {
        public Sprite Item1 { get => _item1; set => _item1 = value; }
        public Sprite Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Sprite _item1;
        [SerializeField]
        private Sprite _item2;

        public void Deconstruct(out Sprite item1, out Sprite item2) { item1 = Item1; item2 = Item2; }
    }
}