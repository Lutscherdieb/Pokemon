using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lutscherdieb.Pokemon{
    public class DestroyAfterDelay : MonoBehaviour{
        [SerializeField] float delay = 2f;
        private void Start() {
            Destroy(gameObject,delay);
        }
    }
}
