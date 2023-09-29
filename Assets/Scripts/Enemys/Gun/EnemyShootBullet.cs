using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootBullet : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float reloadTime;
    public float shootAfter;
    public float bulletSpeed;
    AudioSource shootSound;

    private void Start()
    {

        shootSound = GetComponent<AudioSource>();
        InvokeRepeating("SpawnBullet",shootAfter, reloadTime);
    }

    void SpawnBullet()
    {
        shootSound.Play();
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
    }
}
