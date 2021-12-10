using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

[EditorIcon("atom-icon-sand")]
[CreateAssetMenu(menuName = "Unity Atoms/Conditions/Bool/Check", fileName = "CheckBool")]
public class CheckBool : BoolCondition{
    public bool desiredState;
    public override bool Call(bool value){
        return value == desiredState;
    }
}