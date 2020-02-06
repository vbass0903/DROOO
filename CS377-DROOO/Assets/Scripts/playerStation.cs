using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStation : MonoBehaviour
{
    bool isAttach = false; 
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
            //GetComponent(typeof(PositionConstraint)).constraintActive = true;
            switch (attachedStation)
            {
                case "PilotStation":
                    GameObject submarine = GameObject.Find("Submarine");
                    if (Input.GetAxisRaw("Horizontal") == 1)
                    {
                        submarine.transform.Rotate(Vector3.forward * Input.GetAxis("Horizontal"));
                    }
                    if (Input.GetAxisRaw("Horizontal") == -1)
                    {
                        submarine.transform.Rotate(Vector3.forward * Input.GetAxis("Horizontal"));
                    }
                    break;
                case "TurretStation":
                    Debug.Log("Turret Station");
                    break;
            }
        }
    }
}
