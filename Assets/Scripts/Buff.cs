using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    [CreateAssetMenu(menuName = "Pokemon/Buff/new")]
    public class Buff : ScriptableObject{
        [SerializeField] Sprite image;
        public Sprite Image { get => image; set => image = value; }
        [SerializeField] [Multiline] string description;
        public string Description { get => description; set => description = value; }

    }
    
}
