using System.Collections;
using System.Collections.Generic;
using System.Net;
using DG.Tweening;
using Lutscherdieb.Pokemon;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Editor;
using UnityEngine;
using UnityEngine.UI;
namespace Lutscherdieb.Pokemon{
    [RequireComponent(typeof(Image))]
    public class Unit : MonoBehaviour{
        [Header("Variables")]
        [SerializeField] StringReference unitName;
        [SerializeField] SpriteReference sprite;
        [SerializeField] IntReference hp;
        [SerializeField] IntReference maxHp;
        [SerializeField] IntReference xp;
        [SerializeField] IntReference maxXp;
        [SerializeField] IntReference level;
        [SerializeField] IntReference shield;
        [SerializeField] IntReference maxShield;
        [SerializeField] IntReference armour;
        [SerializeField] FloatReference dodge;
        [SerializeField] IntReference constitution;
        [SerializeField] IntReference strength;
        [SerializeField] IntReference intelligence;
        [SerializeField] IntReference dexterity;
        [SerializeField] IntReference initiatve;
        [SerializeField] FloatReference critChance;
        [SerializeField] UnitTypesValueList unitTypes;
        [SerializeField] BuffValueList buffs;
        [SerializeField] SkillValueList skills;
        [SerializeField] BoolReference playerOwned;
        [Header("Events")]
        [SerializeField] UnitEvent Spawn;
        [SerializeField] UnitEvent Destroyed;
        [SerializeField] UnitEvent DodgedEvent;
        [SerializeField] IntEvent Damaged;
        [SerializeField] IntEvent CritEvent;
        [SerializeField] IntEvent ShieldDamaged;
        [SerializeField] IntEvent Blocked;
        [SerializeField] UnitTypesPairEvent EffectiveAgainst;
        [SerializeField] FloatEvent TypeReductionEvent;
        [Header("Constants")]
        [SerializeField] IntConstant ConstPerLevel;
        [SerializeField] IntConstant StrPerLevel;
        [SerializeField] IntConstant IntPerLevel;
        [SerializeField] IntConstant DexPerLevel;
        [SerializeField] IntConstant MaxLifePerConst;
        [SerializeField] IntConstant ShieldPerIntelligence;
        [SerializeField] FloatConstant ArmourPerStrength;
        [SerializeField] IntConstant ReductionPerArmour;
        [SerializeField] FloatConstant DodgePerDexterity;
        [SerializeField] FloatConstant CritChanceModifier;
        [SerializeField] FloatConstant DamageRange;
        [SerializeField] FloatConstant InitiativeModifier;
        [SerializeField] FloatConstant CritMultiplier;
        [SerializeField] IntConstant XpGainRate;
        [SerializeField] FloatConstant EnterAnimationDuration;
        [SerializeField] FloatConstant EnterAnimationOffset;
        [SerializeField] FloatConstant DeathAnimationDuration;
        [SerializeField] FloatConstant DeathAnimationOffset;
        [SerializeField] FloatConstant HitAnimationDuration;
        [SerializeField] FloatConstant AttackAnimationOffsetX;
        [SerializeField] FloatConstant AttackAnimationOffsetY;

        progressPokemon progress;
        Image image;
        Coroutine hitAnimation;

        public StringReference UnitName { get => unitName; set => unitName = value; }
        public SpriteReference Sprite { get => sprite; set => sprite = value; }
        public IntReference Hp { get => hp; set => hp = value; }
        public IntReference MaxHp { get => maxHp; set => maxHp = value; }
        public IntReference Shield { get => shield; set => shield = value; }
        public IntReference MaxShield { get => maxShield; set => maxShield = value; }
        public IntReference Armour { get => armour; set => armour = value; }
        public FloatReference Dodge { get => dodge; set => dodge = value; }
        public IntReference Xp { get => xp; set => xp = value; }
        public IntReference MaxXp { get => maxXp; set => maxXp = value; }
        public IntReference Level { get => level; set => level = value; }
        public IntReference Constitution { get => constitution; set => constitution = value; }
        public IntReference Strength { get => strength; set => strength = value; }
        public IntReference Intelligence { get => intelligence; set => intelligence = value; }
        public IntReference Dexterity { get => dexterity; set => dexterity = value; }
        public UnitTypesValueList UnitTypes { get => unitTypes; set => unitTypes = value; }
        public BuffValueList Buffs { get => buffs; set => buffs = value; }
        public SkillValueList Skills { get => skills; set => skills = value; }
        public IntReference Initiatve { get => initiatve; set => initiatve = value; }
        public FloatReference CritChance { get => critChance; set => critChance = value; }
        private void Awake() {
            image = GetComponent<Image>();
        }

        public void Init(progressPokemon progress,bool playerOwned) {
            this.progress = progress;
            level.Value = progress.Level;
            this.playerOwned.Value = playerOwned;
            
            
            
            unitName.Value = progress.name;
            sprite.Value = null;
            if(playerOwned){
                sprite.Value = progress.BasePokemon.BackSprite;
            }else{
                sprite.Value = progress.BasePokemon.FrontSprite;
            }
            hp.Value = progress.Hp;
            shield.Value = progress.Shield;
            xp.Value = progress.Xp; 


            // Lists
            unitTypes.Clear();
            foreach (var type in progress.BasePokemon.UnitTypes){
                unitTypes.Add(type);
            }
            skills.Clear();
            foreach (var skill in progress.Skills){
                skills.Add(skill);
            }
            buffs.Clear();
            Spawn.Raise(this);
            
        }

        public void CalculateMaxLife(){
            maxHp.Value = constitution.Value * MaxLifePerConst.Value;
        }
        public void CalculateMaxShield(){
            maxShield.Value = intelligence.Value * ShieldPerIntelligence.Value;
        }
        public void CalculateMaxXp(){
            maxXp.Value = (level.Value * XpGainRate.Value) ^ 2;
        }
        public void CalculateArmour(){
            armour.Value = Mathf.FloorToInt(strength.Value * ArmourPerStrength.Value);
        }
        public void CalculateEvasion(){
            dodge.Value = dexterity.Value * DodgePerDexterity.Value;
        }
        public void CalculateConstitution(){
            constitution.Value = progress.BasePokemon.Constitution + (level.Value * ConstPerLevel.Value);
        }
        public void CalculateStrength(){
            strength.Value = progress.BasePokemon.Strength + (level.Value * StrPerLevel.Value);
        }
        public void CalculateDexterity(){
            dexterity.Value = progress.BasePokemon.Dexterity + (level.Value * DexPerLevel.Value);
        }
        public void CalculateIntelligence(){
            intelligence.Value = progress.BasePokemon.Intelligence + (level.Value * IntPerLevel.Value);
        }
        public void CalculateInitiative(){
            initiatve.Value = Mathf.FloorToInt((intelligence.Value + dexterity.Value) / 2 * InitiativeModifier.Value);
        }
        public void CalculateCritChance(){
            critChance.Value = (dexterity.Value + strength.Value) / 2 * CritChanceModifier.Value;
        }
        public void LevelUp(){
            level.Value += 1;
            xp.Value -= maxXp.Value;
        }
        //-- Animations--//
        public void PlayEnterAnimation(){
            var originalPosition = transform.position;
            if(playerOwned.Value){
                transform.position += new Vector3(-EnterAnimationOffset.Value,0,0);
            }else{
                transform.position += new Vector3(EnterAnimationOffset.Value,0,0);
            }
            transform.DOMoveX(originalPosition.x,EnterAnimationDuration.Value);
        }
        public void PlayDeathAnimation(){
            if(playerOwned.Value){
                transform.DOLocalMoveY(transform.position.y - DeathAnimationOffset.Value,DeathAnimationDuration.Value);
            }else{
                transform.DOLocalMoveY(transform.position.y - DeathAnimationOffset.Value,DeathAnimationDuration.Value);
            }
            StartCoroutine(WaitForDestroy(DeathAnimationDuration.Value));
        }
        public void PlayAttackAnimation(Skill skill){
            var sequenceX = DOTween.Sequence();
            var sequenceY = DOTween.Sequence();
            var originalPosition = transform.position;
            if(playerOwned.Value){
                sequenceX.Append(transform.DOLocalMoveX(originalPosition.x + AttackAnimationOffsetX.Value,skill.Duration/2));
                sequenceY.Append(transform.DOLocalMoveY(originalPosition.y + AttackAnimationOffsetY.Value,skill.Duration/2));
            }else{
                sequenceX.Append(transform.DOLocalMoveX(originalPosition.x - AttackAnimationOffsetX.Value,skill.Duration/2));
                sequenceY.Append(transform.DOLocalMoveY(originalPosition.y - AttackAnimationOffsetY.Value,skill.Duration/2));
            }
            sequenceX.Append(transform.DOLocalMoveX(originalPosition.x,skill.Duration/2));
            sequenceY.Append(transform.DOLocalMoveY(originalPosition.y,skill.Duration/2));
        }
        IEnumerator WaitForDestroy(float delay){
            yield return new WaitForSeconds(delay);
            Destroy(gameObject);
        }
        IEnumerator WaitForHitAnimation(float time){
            yield return new WaitForSeconds(time);
            hitAnimation = null;
        }
        public void PlayHitAnimation(){
            if(hitAnimation == null){
                var originalColor = image.color;
                image.color = Color.gray;
                image.DOColor(originalColor,HitAnimationDuration.Value);
                hitAnimation = StartCoroutine(WaitForHitAnimation(HitAnimationDuration.Value));
            }
        }
        //------------
        public void DealDamage(int amount,Unit source,List<UnitTypes> types,bool canCrit = true,bool ignoreArmour = false,bool ignoreShield = false,bool ignoreDodge = false){
            int damage = Mathf.FloorToInt(Random.Range(amount*(1-DamageRange.Value),amount*(1+DamageRange.Value)));
            bool dodged = false;
             if(!ignoreDodge){
                dodged = Random.Range(0,100) <= dodge.Value;
                if(dodged){
                    DodgedEvent.Raise(this);
                    return;
                }
             }
             if(types.Count > 0 && unitTypes.Count > 0){
                 float multiplier = 1f;
                 foreach (var attackType in types){
                     foreach (var defenderType in unitTypes){
                         multiplier += attackType.GetDamageMultiplier(defenderType);
                         var pair = new UnitTypesPair();
                         pair.Item1 = attackType;
                         pair.Item2 = defenderType;
                         EffectiveAgainst.Raise(pair);
                     }
                 }
                 damage = Mathf.FloorToInt(damage* multiplier);
                 TypeReductionEvent.Raise(multiplier);
             }
             if(canCrit && source.CritChance > 0){
                 if(Random.Range(0,100) <= source.CritChance.Value){
                     var oldDmg = damage;
                     damage = Mathf.FloorToInt(damage * CritMultiplier.Value);
                     CritEvent.Raise(damage-oldDmg);
                 }
             }
             if(!ignoreArmour){
                var reduction = (armour.Value * ReductionPerArmour.Value);
                damage -= reduction;
                Mathf.Clamp(damage,0,Mathf.Infinity);
                if(reduction>0){Blocked.Raise(reduction);}
             }
             if(!ignoreShield && damage > 0){
                 var tmp = shield.Value;
                 shield.Value -= damage;
                 damage -= tmp;
                 Mathf.Clamp(damage,0,Mathf.Infinity);
                 tmp -=shield.Value;
                 if(tmp>0){ShieldDamaged.Raise(tmp);}
             }
             if(damage > 0){
                hp.Value -= damage;
                Damaged.Raise(damage);
             }
        }

        // Save to Progress
        void SaveShield(){
            progress.Shield = shield.Value;
        }
        void SaveXP(){
            progress.Xp = xp.Value;
        }
        void SaveHP(){
            progress.Hp = hp.Value;
        }
        void SaveLevel(){
            progress.Level = level.Value;
        }
        void SaveSkills(){
            progress.Skills.Clear();
            foreach (Skill skill in skills){
                progress.Skills.Add(skill);
            }
        }

        private void OnDestroy() {
            if(progress){
                SaveSkills();
                SaveLevel();
                SaveHP();
                SaveXP();
                SaveShield();
            }
            Destroyed.Raise(this);
        }
    }
}
