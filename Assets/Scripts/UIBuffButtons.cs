using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lutscherdieb.Pokemon{
    public class UIBuffButtons : MonoBehaviour{
        [SerializeField] BuffButton buttonprefab;
        List<BuffButton> buttons = new List<BuffButton>();
        public void Add(Buff buff){
            var tmp = Instantiate<BuffButton>(buttonprefab,transform);
            tmp.Set(buff);
            buttons.Add(tmp);
        }
        public void Remove(Buff buff){
            for (int i=0;i<buttons.Count;i++){
                if(buttons[i].Buff == buff){
                    Destroy(buttons[i].gameObject);
                    buttons.RemoveAt(i);
                    return;
                }
            }
        }
        public void Clear(){
            foreach (var button in buttons){
                Destroy(button.gameObject);
            }
            buttons.Clear();
        }
    }
}