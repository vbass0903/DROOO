using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Station : MonoBehaviour
{
    GameObject attachUI;
    GameObject detachUI;
    public int hitpoints;
    public string nam;


    public Station(int hp, string ID) //Constructor
    {
        hitpoints = hp;
        nam = ID;
    }

    void Awake()
    {
        attachUI = GameObject.Find("attachUI");
        detachUI = GameObject.Find("detachUI");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<playerStation>().attachedStation = gameObject.name;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<playerStation>().attachedStation = null;
        }
    }
}
