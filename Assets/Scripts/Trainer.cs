using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    [CreateAssetMenu(menuName = "Pokemon/Trainer/new")]
    public class Trainer : ScriptableObject{
        [SerializeField] List<progressPokemon> pokemons;
        public List<progressPokemon> Pokemons { get => pokemons; set => pokemons = value; }

        public progressPokemon GetNextUnit(){
            foreach (var unit in pokemons){
                if(unit.Hp > 0){return unit;}
            }
            return null;
        }
    }
}
