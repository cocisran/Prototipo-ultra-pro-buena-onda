using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegresarMenu : MonoBehaviour{
    public void regresar(){
        SceneManager.LoadScene(0);
        GameVariables.restart();
    }
}
