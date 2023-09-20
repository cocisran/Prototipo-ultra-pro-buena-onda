using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float reload_time;
    public float BulletSpeed;
    public static float reload_timer;
    AudioSource shootSound;

    private void Start()
    {
        reload_timer = 0;
        shootSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        reload_timer = reload_timer <= 0 ? 0 : reload_timer - Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (reload_timer <= 0)
            {
                SpawnBullet();
                shootSound.Play();
                reload_timer = reload_time;

            }
        }
        
    }

    void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * BulletSpeed;
    }
}
