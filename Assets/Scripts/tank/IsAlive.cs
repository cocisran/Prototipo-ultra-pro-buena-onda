using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAlive : MonoBehaviour
{
    public float time_multiplicator = 1f;
    
    void Update()
    {
        GameVariables.score += time_multiplicator * Time.deltaTime;
        Debug.Log(GameVariables.lifes);
    }
}
