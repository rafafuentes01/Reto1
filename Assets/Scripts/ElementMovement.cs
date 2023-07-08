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
        // Calculate the next position based on the direction
        float nextXPosition = transform.position.y + (Velocidad * direction * Time.deltaTime);

        // Check if the element has reached the movement distance
        if (Mathf.Abs(nextXPosition - initialPosition.y) >= Distancia)
        {
            // Reverse the direction
            direction *= -1;
        }

        // Update the position
        transform.position = new Vector3(transform.position.x, nextXPosition, transform.position.z);
    }

}
