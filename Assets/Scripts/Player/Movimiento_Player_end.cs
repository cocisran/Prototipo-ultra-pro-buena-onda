using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Player_end : MonoBehaviour{

    public float speed, rotationSpeed;
    public float hm;

    void Update(){
        hm = Input.GetAxis("Horizontal");
        // Right movement
        if ( hm > 0 && this.transform.position.x >= GameVariables.upperAxisXConstrain) return;
        // Left movement
        if ( hm < 0 && this.transform.position.x <= GameVariables.lowerAxisXConstrain) return;
        this.transform.Translate(Time.deltaTime * speed * hm, 0, 0);
    }
}