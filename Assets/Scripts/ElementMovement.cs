using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementMovement : MonoBehaviour
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
        
        float nextXPosition = transform.position.y + (Velocidad * direction * Time.deltaTime);

        
        if (Mathf.Abs(nextXPosition - initialPosition.y) >= Distancia)
        {
           
            direction *= -1;
        }

        
        transform.position = new Vector3(transform.position.x, nextXPosition, transform.position.z);
    }

}
