using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        //camera control to look at player
        transform.LookAt(player.transform);
    }
}
