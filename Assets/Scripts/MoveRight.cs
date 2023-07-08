using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{

    public float speed = 5f; // Speed of movement

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
