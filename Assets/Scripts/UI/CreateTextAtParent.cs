using System;
using System.Collections;
using System.Collections.Generic;
using Lutscherdieb.Pokemon;
using TMPro;
using UnityEngine;
namespace Lutscherdieb.Pokemon{
    public class CreateTextAtParent : MonoBehaviour{
        [SerializeField] string preText ="";
        [SerializeField] string postText ="";
        [SerializeField] Color color;
        [SerializeField] TMPro.TMP_Text textPrefab;
        [SerializeField] Vector3 spawnOffset = Vector3.zero;

        public string PostText { get => postText; set => postText = value; }
        public string PreText { get => preText; set => preText = value; }
        public Color Color { get => color; set => color = value; }
        public Vector3 SpawnOffset { get => spawnOffset; set => spawnOffset = value; }

        public void Create(String textContent){
            var txt = Instantiate<TMP_Text>(textPrefab,transform);
            txt.text = preText + textContent + postText;
            txt.color = color;
            txt.transform.position += spawnOffset;
        }
        public void Create(int value){
            var txt = Instantiate<TMP_Text>(textPrefab,transform);
            txt.text = preText + value.ToString() + postText;
            txt.color = color;
            txt.transform.localPosition += spawnOffset;
        }

    }
}
