using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    private bool active;
    AudioSource repairSound;

    private void Start()
    {
        active = true;
        repairSound = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player" || !active) return;
        active = false;
        GameVariables.score += 10;
        if (GameVariables.lifes < GameVariables.initialLifes) {
            GameVariables.lifes++;
        }
        repairSound.Play();
        GetComponent<Renderer>().enabled = false;
        Destroy(this.gameObject, repairSound.clip.length);
    }
}
