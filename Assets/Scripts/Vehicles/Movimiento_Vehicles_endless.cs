using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Vehicles_endless : MonoBehaviour{

    void LateUpdate(){
        this.transform.Translate(0, 0, Time.deltaTime * GameVariables.enemySpeed);
    }
}
