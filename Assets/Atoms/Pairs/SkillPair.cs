using System;
using UnityEngine;
using Lutscherdieb.Pokemon;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Skill&gt;`. Inherits from `IPair&lt;Skill&gt;`.
    /// </summary>
    [Serializable]
    public struct SkillPair : IPair<Skill>
    {
        public Skill Item1 { get => _item1; set => _item1 = value; }
        public Skill Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Skill _item1;
        [SerializeField]
        private Skill _item2;

        public void Deconstruct(out Skill item1, out Skill item2) { item1 = Item1; item2 = Item2; }
    }
}