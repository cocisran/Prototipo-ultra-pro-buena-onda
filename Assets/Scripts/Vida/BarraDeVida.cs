using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour{

    private Slider slider;

    void Start(){
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        CambiarVidaActual(GameVariables.lifes);
    }

    public void CambiarVidamaxima(float vidaMaxima){
        slider.maxValue = vidaMaxima;
    }

    public void CambiarVidaActual(float cantidadVida){
        slider.value = cantidadVida;
    }

    public void InicializarBarraDeVida(float cantidadVida){
        CambiarVidamaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }
}
