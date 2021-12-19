using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    [CreateAssetMenu(menuName = "Pokemon/Progress/new")]
    public class progressPokemon : ScriptableObject{
        [SerializeField] basePokemon basePokemon;
        public basePokemon BasePokemon { get => basePokemon; set => basePokemon = value; }
        [SerializeField] int hp;
        public int Hp { get => hp; set => hp = value; }
        [SerializeField] int xp;
        public int Xp { get => xp; set => xp = value; }
        [SerializeField] int level;
        public int Level { get => level; set => level = value; }
        [SerializeField] int shield;
        public int Shield { get => shield; set => shield = value; }
        [SerializeField] List<Skill> skills;
        public List<Skill> Skills { get => skills; set => skills = value; }
        [SerializeField] Rarity rarity;
        public Rarity Rarity { get => rarity; set => rarity = value; }


    }
}
