using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour{
    public void reiniciarJuego(){
        SceneManager.LoadScene(1);
        GameVariables.restart();
    }
}
