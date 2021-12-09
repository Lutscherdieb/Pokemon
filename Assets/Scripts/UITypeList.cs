using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lutscherdieb.Pokemon{
    public class UITypeList : MonoBehaviour{
        [SerializeField] TypeSetter typePrefab;
        List<TypeSetter> uiTypes = new List<TypeSetter>();
        List<UnitTypes> types = new List<UnitTypes>();
        public void Add(UnitTypes type){
            types.Add(type);
            var tmp = Instantiate<TypeSetter>(typePrefab,transform);
            uiTypes.Add(tmp);
            tmp.Set(type);
        }
        public void Remove(UnitTypes type){
            int id = types.IndexOf(type);
            types.Remove(type);
            Destroy(uiTypes[id].gameObject);
            uiTypes.RemoveAt(id);
        }
        public void Clear(){
        foreach (var item in uiTypes){
            Destroy(item.gameObject);
        }
        uiTypes = new List<TypeSetter>();
        types = new List<UnitTypes>();
        }
    }
}
