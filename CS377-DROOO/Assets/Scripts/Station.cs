using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Station : MonoBehaviour
{

    GameObject Player;
    GameObject attachUI;
    GameObject detachUI;
    bool isAttached = false;
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
        attachUI = GameObject.Find("attachUI");
        detachUI = GameObject.Find("detachUI");
    }

    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" && !isAttached) //Tell playerUI that the player is touching the station and is not yet attached
        {
            attachUI.GetComponent<playerUI>().isTouching = true;
        }
        else if (collision.collider.tag == "Player" && isAttached) //Tell PlayerUI that the player is attached and to show detach UI
        {
            detachUI.GetComponent<playerUI>().isTouching = true;
        }

        if (Input.GetButton("Cancel") && collision.collider.tag == "Player") //If esc pressed and collision with Player
        {
            Player.GetComponent<playerStation>().attachedStation = gameObject.name;
            Player.GetComponent<playerMove>().isAttached = true;
            attachUI.GetComponent<playerUI>().isTouching = false;
            isAttached = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player") //Tell playerUI that the player is not touching the station
        {
            attachUI.GetComponent<playerUI>().isTouching = false;
            detachUI.GetComponent<playerUI>().isTouching = false;
            isAttached = false;
        }
    }
}
