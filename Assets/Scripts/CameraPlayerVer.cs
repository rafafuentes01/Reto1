using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerVer : MonoBehaviour
{
    public Transform player;
    public float separacion = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.position.y + separacion, transform.position.z);
    }
}
