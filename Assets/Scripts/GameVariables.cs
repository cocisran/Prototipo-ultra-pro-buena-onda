using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVariables : MonoBehaviour{
    private static readonly float initialValuePistaSpeed = 25;
    private static readonly float initialValuenemySpeedValue = 30;
    private static readonly float initialScore = 0;
    private static readonly float initialSpawnProbability = 60;

    public static float pistaSpeed = initialValuePistaSpeed;
    public static float enemySpeed = initialValuenemySpeedValue;
    public static float score = initialScore;
    public static float spawnProbability = initialSpawnProbability;
    public static int NumPista = 0;

    public static readonly float upperAxisXConstrain = 27;
    public static readonly float lowerAxisXConstrain = -27;

    public static void restart(){
        pistaSpeed = initialValuePistaSpeed;
        enemySpeed = initialValuenemySpeedValue;
        score = initialScore;
        spawnProbability = initialSpawnProbability;
        NumPista = 0;
    }
}
