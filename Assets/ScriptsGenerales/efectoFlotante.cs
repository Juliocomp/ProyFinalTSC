using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectoFlotante : MonoBehaviour
{
    public float amplitude = 0.5f;  // Altura del movimiento
    public float speed = 3.0f;       // Velocidad del movimiento

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + new Vector3(0f, Mathf.Sin(Time.time * speed) * amplitude, 0f);
    }
}
