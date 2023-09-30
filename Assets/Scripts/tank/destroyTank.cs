using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyTank : MonoBehaviour{

    [SerializeField] private BarraDeVida barraDeVida;
    public GameObject tankDestroyed;
    public GameObject loseScreen;
    private bool active;
    private float max_life;

    private Color colorPeligro = Color.white;
    [SerializeField] private Image imagen;

    private void Start(){
        
        active = true;
        barraDeVida.InicializarBarraDeVida(GameVariables.lifes);
        imagen.color = colorPeligro;
        max_life = GameVariables.lifes;
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.tag);
        if ((collision.gameObject.tag != "Vehicle" &&
             collision.gameObject.tag != "Enemy" &&
             collision.gameObject.tag != "EnemyBullet" )
            || !active || GameVariables.inmortal) return;
        active = false;
       
        if (collision.gameObject.tag == "Vehicle")
            GameVariables.score -= 100;
        if (collision.gameObject.tag == "Enemy")
            GameVariables.score = 50;

       
        Invoke("setActive", 0.5f);
        GameVariables.lifes -= GameVariables.lifes <= 0 ? 0 : 1;

        // barraDeVida.CambiarVidaActual(GameVariables.lifes);
        if (GameVariables.lifes < max_life/2) colorPeligro = Color.red;
        else colorPeligro = Color.white;
        imagen.color = colorPeligro;

        if (GameVariables.lifes <= 0)
        {
            
            Instantiate(tankDestroyed, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
            GameVariables.pistaSpeed = 0;
            loseScreen.SetActive(true);
        }
    }

   void setActive()
    {
        this.active = true;
    }
}