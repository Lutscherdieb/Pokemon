using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

public class BattleKI : MonoBehaviour{
    [SerializeField] SkillEvent enemyUseSkill;
    [SerializeField] UnitVariable enemyUnit;
    public void RandomMove(){
        enemyUseSkill.Raise(enemyUnit.Value.Skills[Random.Range(0,enemyUnit.Value.Skills.Count - 1)]);
    }
}
