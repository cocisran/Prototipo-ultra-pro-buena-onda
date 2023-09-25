using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTank : MonoBehaviour{

    public GameObject tankDestroyed;
    public GameObject loseScreen;
    private bool active;

    private void Start(){
        active = true;
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag != "Vehicle" || !active) return;
        active = false;
        Instantiate(tankDestroyed, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
        GameVariables.pistaSpeed = 0;
        loseScreen.SetActive(true);
    }
}