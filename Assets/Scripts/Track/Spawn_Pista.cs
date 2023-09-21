using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Pista : MonoBehaviour{

    public GameObject track;
    public Transform spawn;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            Instantiate(track, spawn.position, spawn.rotation);
            GameVariables.enemySpeed += 3;
            GameVariables.pistaSpeed += 3;
        }
    }
}
