using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    public class EnableChild : MonoBehaviour{

        [SerializeField] List<GameObject> gameObjects;

        public void SetValue(int value){
            for (int i=0;i<gameObjects.Count;i++){
                gameObjects[i].SetActive(i< value);
            }
        }
    }
}
