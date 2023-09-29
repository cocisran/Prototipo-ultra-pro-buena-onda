using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_PowerUp_endless : MonoBehaviour
{

    public float rotationSpeed = 80f;
    public float frequency = 0.5f;
    public float amplitude = 0.0001f;

    void LateUpdate()
    {
        float yOffset = Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        //this.transform.Translate(0, yOffset, 0, Space.Self);

        this.transform.Translate(0, 0, Time.deltaTime * GameVariables.powerUpSpeed * -1, Space.World);

        this.transform.Rotate(Vector3.right, rotationSpeed * Mathf.PI * Time.deltaTime);
    }
}
