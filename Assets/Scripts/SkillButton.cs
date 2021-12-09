using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Lutscherdieb.Pokemon{
    public class SkillButton : MonoBehaviour{
        [SerializeField] TMPro.TMP_Text nameTMP;
        [SerializeField] Image image;
        [SerializeField] SkillEvent useSkill;
        Skill skill;
        public Skill Skill { get => skill;}

        public void Set(Skill skill){
            this.skill = skill;
            if(nameTMP!=null){nameTMP.text = skill.name;}
            if(image!=null) {image.sprite = skill.Image;}

        }
        public void UseSkill(){
            useSkill.Raise(skill);
        }
    }
}
