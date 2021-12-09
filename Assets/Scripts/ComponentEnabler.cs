using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentEnabler : MonoBehaviour{
    [SerializeField] List<MonoBehaviour> enableList;

    public void Enable(bool enable){
        foreach (var item in enableList){
            item.enabled = enable;
        }
    }
}
