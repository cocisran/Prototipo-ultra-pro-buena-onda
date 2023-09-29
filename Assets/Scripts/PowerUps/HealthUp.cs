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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" || !active) return;
        active = false;
        GameVariables.score += 10;
        repairSound.Play();
        Destroy(this.gameObject, repairSound.clip.length);
    }
}
