using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    static bool isSpawned = false;
    [SerializeField] GameObject musicObjectPrefab;

private void Start(){
    if(!isSpawned){
        Instantiate(musicObjectPrefab);
        isSpawned = true;
    }
}
}
