using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

namespace Lutscherdieb.Pokemon{
    public abstract class Skill : ScriptableObject{
        [SerializeField] Sprite image;
        public Sprite Image { get => image;}
        [SerializeField] [Multiline] string description;
        public string Description { get => description;}
        [SerializeField] float duration = 1.5f;
        public float Duration { get => duration;}
        [SerializeField] List<UnitTypes> types;
        public List<UnitTypes> Types { get => types;}
        [SerializeField][Range(0,200)] int basePower = 100;
        public int BasePower { get => basePower;}
        [SerializeField] [Range(0,5)] float strengthMultiplier = 1;
        public float StrengthMultiplier { get => strengthMultiplier;}
        [SerializeField] [Range(0,5)] float intelligenceMultiplier = 1;
        public float IntelligenceMultiplier { get => intelligenceMultiplier; }
        [SerializeField] [Range(0,5)] float dexterityMultiplier = 1;
        public float DexterityMultiplier { get => dexterityMultiplier;}
        [SerializeField] [Range(0,5)] float constitutionMultiplier = 1;
        public float ConstitutionMultiplier { get => constitutionMultiplier;}

        public int Power(Unit user){
            return Mathf.FloorToInt( (BasePower + StrengthMultiplier * user.Strength.Value + user.Intelligence.Value * IntelligenceMultiplier + user.Dexterity.Value * DexterityMultiplier + user.Constitution.Value * ConstitutionMultiplier) / 10);
        }

        public abstract void Use(Unit user,Unit enemy);


    }
    
}
