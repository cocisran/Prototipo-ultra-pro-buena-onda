using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Player_end : MonoBehaviour{

    public float speed, rotationSpeed;
    public float vm, hm;

    void Update() {
        hm = Input.GetAxis("Horizontal");
        // Right movemente
        if(  hm > 0 && this.transform.position.x <= GameVariables.upperAxisXConstrain)
            this.transform.Translate(Time.deltaTime * speed * hm, 0, 0);
        // Left movement
        if( hm < 0 && this.transform.position.x >= GameVariables.lowerAxisXConstrain)
            this.transform.Translate(Time.deltaTime * speed * hm, 0, 0);
    }
}
