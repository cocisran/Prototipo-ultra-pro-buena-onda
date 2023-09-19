using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_automatico : MonoBehaviour{

    public float speed = 10;

    // Update is called once per frame
    void FixedUpdate(){
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
