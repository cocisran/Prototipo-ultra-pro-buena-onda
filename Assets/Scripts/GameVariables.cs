using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVariables : MonoBehaviour{
   private static readonly float initialValuePistaSpeed = 15;
   private static readonly float initialValuenemySpeedValue = 20;
   private static readonly float initialScore = 0;

   public static float pistaSpeed = initialValuePistaSpeed;
   public static float enemySpeed = initialValuenemySpeedValue;
   public static float score = initialScore;

    public static void restart(){
        pistaSpeed = initialValuePistaSpeed;
        enemySpeed = initialValuenemySpeedValue;
        score = initialScore;
    }
}
