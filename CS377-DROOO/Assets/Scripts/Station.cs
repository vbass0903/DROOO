using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Station : MonoBehaviour
{

    public GameObject Player;
    public int hitpoints;
    public string name;

    public Station(int hp, string ID) //Constructor
    {
        hitpoints = hp;
        name = ID;
    }

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Touched");
        if (Input.GetButton("Cancel") && collision.collider.tag == "Player")
        {
            Player.GetComponent<playerStation>().attachedStation = gameObject.name;
            Player.GetComponent<playerMove>().isAttached = true;
        }
    }
}
