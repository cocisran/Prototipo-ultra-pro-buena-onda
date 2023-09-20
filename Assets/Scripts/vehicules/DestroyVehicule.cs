using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVehicule : MonoBehaviour
{
    public GameObject vehiculeDestroyed;
    private bool active;

    private void Start()
    {
        active = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet" && active)
        {
            active = false;
            GameObject destroyed =Instantiate(vehiculeDestroyed, gameObject.transform.position, gameObject.transform.rotation);
            GameVariables.score += 20;
            Destroy(gameObject);
            Destroy(destroyed, 3f);
        }
    }

}
