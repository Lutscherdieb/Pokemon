using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine.UI;
using UnityAtoms.Editor;
namespace Lutscherdieb.Pokemon{
[RequireComponent(typeof(Slider))]
    public class ValueBar : MonoBehaviour{

        [SerializeField] TMPro.TMP_Text valuesText;
        Slider slider;

        public void SetValue(int value = 100){
            slider ??= GetComponent<Slider>();
            if(value < slider.maxValue){
                slider.value = value;
            }else{
                slider.value = slider.maxValue;
            }
            if(valuesText){
                valuesText.text = $"{slider.value}/{slider.maxValue}";
            }
        }
        public void SetValueSmooth(int value = 100){
            StartCoroutine(SmoothValue(value));
        }
        IEnumerator SmoothValue(int value){
            slider ??= GetComponent<Slider>();
            int changeAmount = (int)slider.value - value;
            while (changeAmount != 0){
                if(changeAmount > 0){
                    SetValue((int)slider.value - 1);
                    changeAmount--;
                }else{
                    SetValue((int)slider.value + 1);
                    changeAmount++;
                }
                yield return null;
            }
        }
        public void SetMaxValue(int value = 100){
            slider ??= GetComponent<Slider>();
            var tmp = slider.value;
            slider.maxValue = value;
            slider.value = tmp > value ? value : tmp;
            if(valuesText){
                valuesText.text = $"{slider.value}/{slider.maxValue}";
            }
        }
    }
}
