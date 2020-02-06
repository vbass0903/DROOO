using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStation : MonoBehaviour
{
    bool isAttach = false;
    public float moveSpeed = 5f; //Copied from playerMove, can be changed to change submarine move speed
    public string attachedStation = null;

    void Start()
    {
        //Set equal to attached status from playerMove
        isAttach = gameObject.GetComponent<playerMove>().isAttached;
    }

    void Update()
    {
        isAttach = gameObject.GetComponent<playerMove>().isAttached; //Update isAttach
        if (isAttach && Input.GetButton("Submit")) //Disconnect from station
        {
            isAttach = false;
            gameObject.GetComponent<playerMove>().isAttached = false;
        }
    }
    
    void FixedUpdate()
    {
        if (isAttach)
        {
            switch (attachedStation)
            {
                case "PilotStation":
                    GameObject submarine = GameObject.Find("Submarine");

                    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
                    submarine.transform.position += movement * Time.fixedDeltaTime * moveSpeed; //Update position of submarine
                    transform.position += movement * Time.fixedDeltaTime * moveSpeed; //Update player position to stay relevant to sub movement
                    break;
                case "TurretStation":
                    Debug.Log("Turret Station");
                    break;
            }
        }
    }
}
