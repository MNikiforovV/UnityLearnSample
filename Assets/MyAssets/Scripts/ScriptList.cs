using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptList : MonoBehaviour
{
    public List<SampleScript> Scripts;

    public void UseAll(){
        foreach(var s in Scripts){
            s.Use();
        }
    }
}
