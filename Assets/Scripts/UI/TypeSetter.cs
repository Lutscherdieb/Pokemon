using System.Collections;
using System.Collections.Generic;
using Lutscherdieb.Pokemon;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Lutscherdieb.Pokemon{
    public class TypeSetter : MonoBehaviour{
        [SerializeField]Image image;
        [SerializeField]TMP_Text text;

        public void Set(UnitTypes type){
            image.color = type.Color;
            text.text = type.name;
        }
    }
}
