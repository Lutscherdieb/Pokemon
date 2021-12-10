using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
namespace Lutscherdieb.Pokemon{
    public class FloatingText : MonoBehaviour{
        public FloatConstant speed;
        private void Update() {
            Vector3 newPosition = transform.position;
            newPosition.y += 0.1f * speed.Value;
            transform.position = newPosition;
        }
    }
}
