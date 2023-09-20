using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float lifeSpan = 4;
    private void Awake()
    {
        Destroy(gameObject, lifeSpan);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 0.2f);
    }
}
