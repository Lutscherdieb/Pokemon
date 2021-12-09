using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    [CreateAssetMenu(menuName = "Pokemon/Type/new")]
    public class UnitTypes : ScriptableObject{
        [SerializeField] Color color;
        public Color Color { get => color; set => color = value; }
        [SerializeField] List<UnitTypes> strongAgainst;
        [SerializeField] List<UnitTypes> weakAgainst;
        [SerializeField] FloatConstant typeMultiplier;
        public float GetDamageMultiplier(UnitTypes type){
            if(strongAgainst.Contains(type)){
                return typeMultiplier.Value;
            }
            if(strongAgainst.Contains(type)){
                return -typeMultiplier.Value;
            }
            return 0f;
        }
    }
    
}
