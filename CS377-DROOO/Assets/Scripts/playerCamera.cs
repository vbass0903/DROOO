using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        //Camera follows Player1
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
