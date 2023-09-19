using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Player_end : MonoBehaviour{

    public float speed, rotationSpeed;
    public float vm, hm;

    void Update() {
        // vm = Input.GetAxis("Vertical");
        hm = Input.GetAxis("Horizontal");

        this.transform.Translate(Time.deltaTime * speed * hm, 0, 0);
        // this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * hm);
    }

}
