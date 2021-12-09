using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
namespace Lutscherdieb.Pokemon{
    [RequireComponent(typeof(TMP_Text))]
    public class textSetter : MonoBehaviour{
        TMP_Text text;

        private void Awake() {
            text = GetComponent<TMP_Text>();
        }
        public void Set(int toText){
            text.text = toText.ToString();
        }
        public void Set(float toText){
            text.text = toText.ToString();
        }
    }
}
