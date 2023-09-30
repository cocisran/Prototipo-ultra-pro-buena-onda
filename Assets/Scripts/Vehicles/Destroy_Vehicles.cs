using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Vehicles : MonoBehaviour{

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Vehicle")) Destroy(other.gameObject, 1.0f);
        if (other.gameObject.CompareTag("Enemy")) Destroy(other.gameObject, 1.0f);
        if (other.gameObject.CompareTag("PowerUp")) Destroy(other.gameObject, 1.0f);

    }

    }
