using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawMovement : MonoBehaviour{
    public GameObject[] vehicules;
    public float spawnSpeed = 5;
    private int direccion = 1;

    void Start(){
        InvokeRepeating( "spawnVehicule" , 0, 0.3f);
    }

    void FixedUpdate(){
        if ( this.transform.position.x >= GameVariables.upperAxisXConstrain-1) direccion = -1;
        if ( this.transform.position.x <= GameVariables.lowerAxisXConstrain-1) direccion = 1;
        float noise = Random.Range(0f,1f);
        this.transform.Translate(Time.deltaTime * spawnSpeed * direccion * noise, 0, 0);
    }

    private void spawnVehicule(){
        int vehicule_number = Random.Range(0, vehicules.Length);
        int spawn_posibility = Random.Range(0, 100);
        if (spawn_posibility <= GameVariables.spawnProbability)
            Instantiate(vehicules[vehicule_number], this.transform.position, new Quaternion(0,180,0,0));
    }
}