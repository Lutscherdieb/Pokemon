using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    [CreateAssetMenu(menuName = "Pokemon/Type/new")]
    public class UnitTypes : ScriptableObject{
        [SerializeField] Color color;
        public Color Color { get => color; set => color = value; }
    }
    
}
