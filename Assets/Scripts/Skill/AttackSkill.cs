using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lutscherdieb.Pokemon{
    [CreateAssetMenu(menuName = "Pokemon/Skill/new Attack Skill")]
    public class AttackSkill : Skill{
        
        public override void Use(Unit user, Unit enemy){
            //Play Animation
            enemy.DealDamage(Power(user),user,Types);
        }
    }
    
}
