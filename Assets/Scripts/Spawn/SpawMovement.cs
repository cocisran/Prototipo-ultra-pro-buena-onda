using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] vehicules;
    public float spawnSpeed = 5;
    private int direccion = 1;
    void Start()
    {
        InvokeRepeating("spawnVehicule", 0, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if ( this.transform.position.x >= 27)
            direccion = -1;
        if (this.transform.position.x  <=  -27)
            direccion = 1;
        float noise = Random.Range(0f,1f);
        this.transform.Translate(Time.deltaTime * spawnSpeed * direccion * noise, 0, 0);
    }


    void spawnVehicule()
    {
        int v = Random.Range(0, vehicules.Length);
        int active = Random.Range(0, 100);
        if (active <= GameVariables.spawnProbability)
            Instantiate(vehicules[v], this.transform.position, new Quaternion(0,180,0,0));
    }

}
