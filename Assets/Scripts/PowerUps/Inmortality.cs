using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inmortality : MonoBehaviour
{
    private bool active;
    AudioSource inmortalSound;

    private void Start()
    {
        active = true;
        inmortalSound = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player" || !active) return;
        active = false;
        GameVariables.score += 10;
        if(GameVariables.inmortal == false)
        {
            GameVariables.inmortal = true;
            inmortalSound.Play();
            Invoke("Finish", inmortalSound.clip.length);
        }
        GetComponent<Renderer>().enabled = false;
        Destroy(this.gameObject, inmortalSound.clip.length);
    }

    private void Finish()
    {
        if (GameVariables.inmortal == true)
        {
            GameVariables.inmortal = false;
        }
    }
}
