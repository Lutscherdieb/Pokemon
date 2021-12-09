using System.Collections;
using System.Collections.Generic;
using Lutscherdieb.Pokemon;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    [CreateAssetMenu(menuName = "Pokemon/Base/new")]
    public class basePokemon : ScriptableObject{
        [SerializeField] Sprite frontSprite;
        public Sprite FrontSprite { get => frontSprite; set => frontSprite = value; }
        [SerializeField] Sprite backSprite;
        public Sprite BackSprite { get => backSprite; set => backSprite = value; }
        [SerializeField] int constitution;
        public int Constitution { get => constitution; set => constitution = value; }
        [SerializeField] int strength;
        public int Strength { get => strength; set => strength = value; }
        [SerializeField] int intelligence;
        public int Intelligence { get => intelligence; set => intelligence = value; }
        [SerializeField] int dexterity;
        public int Dexterity { get => dexterity; set => dexterity = value; }
        [SerializeField] List<UnitTypes> unitTypes;
        public List<UnitTypes> UnitTypes { get => unitTypes; set => unitTypes = value; }
    }
}
