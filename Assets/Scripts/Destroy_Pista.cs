using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Pista : MonoBehaviour{

    public GameObject track;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")) Destroy(track, 1.0f);
    }
}
