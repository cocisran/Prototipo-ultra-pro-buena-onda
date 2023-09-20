using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVariables : MonoBehaviour
{
   private static readonly float InitialValuepistaSpeed = 15;
   private static readonly float InitialValuenemySpeedValue = 20;
   private static readonly float InitialScore = 0;

   public static float pistaSpeed = InitialValuepistaSpeed;
   public static float enemySpeed = InitialValuenemySpeedValue;
   public static float score = InitialScore;


    public static void restart()
    {
        pistaSpeed = InitialValuepistaSpeed;
        enemySpeed = InitialValuenemySpeedValue;
        score = InitialScore;
    }

}
