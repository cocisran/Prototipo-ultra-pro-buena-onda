using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Pista_endless : MonoBehaviour{

    public float speed;

    void LateUpdate(){
        this.transform.Translate(Time.deltaTime * speed, 0, 0);
    }
}
