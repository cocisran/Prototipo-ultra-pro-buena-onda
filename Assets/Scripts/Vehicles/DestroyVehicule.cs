using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVehicule : MonoBehaviour{
    public GameObject vehiculeDestroyed;
    private bool active;

    private void Start(){
        active = true;
    }
    private void OnCollisionEnter(Collision collision){
        if ((collision.gameObject.tag != "Bullet" && 
              collision.gameObject.tag != "Enemy" && 
              collision.gameObject.tag != "EnemyBullet" &&
               collision.gameObject.tag != "Player") || !active) return;
        active = false;
        Invoke("destroy", 0.1f);
        if (collision.gameObject.tag == "Bullet")
            GameVariables.score -= 100;

    }


    private void destroy()
    {
        Vector3 velocity = gameObject.GetComponent<Rigidbody>().velocity;
        GameObject destroyed = Instantiate(vehiculeDestroyed, gameObject.transform.position, gameObject.transform.rotation);
        destroyed.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
        foreach (Rigidbody component in destroyed.GetComponentsInChildren<Rigidbody>()  )
        {
            component.velocity = velocity;
        }
        Destroy(gameObject);
        Destroy(destroyed, 1f);
       
    }
}
