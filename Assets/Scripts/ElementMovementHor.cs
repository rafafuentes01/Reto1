using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementMovementHor : MonoBehaviour
{
    public float Velocidad = 1f;
    public float Distancia = 2f;
    private Vector3 initialPosition;
    private int direction = 1;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        
        float nextXPosition = transform.position.x + (Velocidad * direction * Time.deltaTime);

        
        if (Mathf.Abs(nextXPosition - initialPosition.x) >= Distancia)
        {
            
            direction *= -1;
        }

        
        transform.position = new Vector3(nextXPosition, transform.position.y, transform.position.z);
    }

}
