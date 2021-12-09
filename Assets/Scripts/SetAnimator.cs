using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lutscherdieb.Pokemon{
    public class SetAnimator : MonoBehaviour{
        [SerializeField] Animator animator;
        [SerializeField] string animatorName = "Show";
    
    private void Awake() {
        animator = GetComponent<Animator>();
    }
    public void SetBool(bool value){
        animator.SetBool(animatorName,value);
    }
    }
}
