using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stationControl : MonoBehaviour
{

    public GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Press F to pay Respects");
            Player.GetComponent<playerMove>().isAttached = true;
        }
    }
}
