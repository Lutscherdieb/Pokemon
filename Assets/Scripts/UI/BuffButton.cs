using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Lutscherdieb.Pokemon{
    public class BuffButton : MonoBehaviour{
        [SerializeField] TMPro.TMP_Text nameTMP;
        [SerializeField] Image image;
        [SerializeField] BuffEvent ClickBuff;
        Buff buff;
        public Buff Buff { get => buff;}

        public void Set(Buff buff){
            this.buff = buff;
            if(nameTMP!=null){nameTMP.text = buff.name;}
            if(image!=null) {image.sprite = buff.Image;}

        }
        public void UseSkill(){
            if(ClickBuff) {ClickBuff.Raise(buff);}
        }
    }
}
