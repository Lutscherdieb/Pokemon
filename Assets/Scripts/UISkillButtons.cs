using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Lutscherdieb.Pokemon{
    public class UISkillButtons : MonoBehaviour{
        [SerializeField] SkillButton buttonprefab;
        List<SkillButton> buttons = new List<SkillButton>();
        public void Add(Skill skill){
            var tmp = Instantiate<SkillButton>(buttonprefab,transform);
            tmp.Set(skill);
            tmp.gameObject.SetActive(enabled);
            buttons.Add(tmp);
        }
        public void Remove(Skill skill){
            for (int i=0;i<buttons.Count;i++){
                if(buttons[i].Skill == skill){
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
        private void OnEnable() {
            foreach (var item in buttons){
                item.gameObject.SetActive(true);
            }
        }
        private void OnDisable() {
            foreach (var item in buttons){
                item.gameObject.SetActive(false);
            }
        }
    }
}
