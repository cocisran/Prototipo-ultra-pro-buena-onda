using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    public TMP_Text score;
   
    void Update()
    {
        score.text = ((int)GameVariables.score).ToString();
    }
}
