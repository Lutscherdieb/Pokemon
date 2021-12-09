using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    public class InvertBool : MonoBehaviour{
        [SerializeField] BoolReference Bool;
        public void Do(){
            Bool.Value = !Bool.Value;
        }
    }
}
