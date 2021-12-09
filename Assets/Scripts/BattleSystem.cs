using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    public class BattleSystem : MonoBehaviour{
        [SerializeField] Trainer trainer;
        [SerializeField] Trainer enemyTrainer;
        [SerializeField] BoolVariable playerWin;
        [SerializeField] BoolVariable playerTurn;
        [SerializeField] BoolVariable enemyWin;
        [SerializeField] UnitVariable playerUnit;
        [SerializeField] UnitVariable enemyUnit;
        [SerializeField] Transform unitParent;
        [SerializeField] Transform enemyUnitParent;
        [SerializeField] Unit unitPrefab;
        [SerializeField] Unit enemyUnitPrefab;
        Coroutine skillCoroutine;
        

        private void Start() {
            StartBattle(trainer,enemyTrainer);
        }  
        IEnumerator WaitForStart(){
            yield return new WaitForSeconds(2f);
            CheckInitiative();
        }
        public void StartBattle(Trainer trainer,Trainer enemyTrainer){
            this.trainer = trainer;
            this.enemyTrainer = enemyTrainer;
            NextPlayerUnit();
            NextEnemyUnit();
            //CheckInitiative();
            StartCoroutine(WaitForStart());
        }
        public void NextPlayerUnit(){
            var progress = trainer.GetNextUnit();
            if(!progress){
                enemyWin.Value = true;
            }else{
                playerUnit.Value = Instantiate<Unit>(unitPrefab,unitParent);
                playerUnit.Value.Init(progress,true);
            }
        }
        public void NextEnemyUnit(){
            var progress = enemyTrainer.GetNextUnit();
            if(!progress){
                playerWin.Value = true;
            }else{
                enemyUnit.Value = Instantiate<Unit>(enemyUnitPrefab,enemyUnitParent);
                enemyUnit.Value.Init(progress,false);
            }
        }
        public void PlayerUseSkill(Skill skill){
            if(playerTurn.Value && skillCoroutine == null){
                skillCoroutine = StartCoroutine(PlayerUseSkillCoroutine(skill));
            }
        }
        public void EnemyUseSkill(Skill skill){
            if(!playerTurn.Value && skillCoroutine == null){
                skillCoroutine = StartCoroutine(EnemyUseSkillCoroutine(skill));
            }
        }
        IEnumerator PlayerUseSkillCoroutine(Skill skill){
            skill.Use(playerUnit.Value,enemyUnit.Value);
            yield return new WaitForSeconds(skill.Duration);
            skillCoroutine = null;
            playerTurn.Value = false;
            RandomEnemyMove();
        }
        IEnumerator EnemyUseSkillCoroutine(Skill skill){
            skill.Use(enemyUnit.Value,playerUnit.Value);
            yield return new WaitForSeconds(skill.Duration);
            skillCoroutine = null;
            playerTurn.Value = true;
        }
        public void CheckInitiative(){
            if(playerUnit.Value.Initiatve.Value >= enemyUnit.Value.Initiatve.Value){
                playerTurn.Value = true;
            }else{
                playerTurn.Value = false;
                RandomEnemyMove();
            }
        }
        public void RandomEnemyMove(){
            EnemyUseSkill(enemyUnit.Value.Skills[Random.Range(0,enemyUnit.Value.Skills.Count -1)]);
        }

    }
}
