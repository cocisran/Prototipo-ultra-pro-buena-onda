using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Vehicles : MonoBehaviour{

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Vehicle")) Destroy(other.gameObject, 1.0f);
    }

    }
