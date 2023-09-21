using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Vehicles : MonoBehaviour{

    public GameObject[] spawns = new GameObject[7];
    public GameObject[] cars = new GameObject[4];

    private int randomNumber;
    void Start(){
        foreach(GameObject spawn in spawns){
            randomNumber = Random.Range(0, 4);
            Instantiate(cars[randomNumber], spawn.transform.position, spawn.transform.rotation);
        }
    }
}
