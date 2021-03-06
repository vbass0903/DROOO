﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Station : MonoBehaviour
{
    GameObject Player;
    GameObject attachUI;
    GameObject detachUI;
    ControllerActions controls;
    bool isAttached = false;
    public int hitpoints;
    public string nam;
    float attachButton;
    float detachButton;


    public Station(int hp, string ID) //Constructor
    {
        hitpoints = hp;
        nam = ID;
    }

    void Awake()
    {
        controls = new ControllerActions();
    }

    void Start()
    {
        Player = GameObject.Find("Player");
        attachUI = GameObject.Find("attachUI");
        detachUI = GameObject.Find("detachUI");
    }

    void Update()
    {
        attachButton = controls.Gameplay.Attach.ReadValue<float>();
        detachButton = controls.Gameplay.Detach.ReadValue<float>();
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

        if (attachButton == 1 && collision.collider.tag == "Player") //If esc pressed and collision with Player
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

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }
    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
