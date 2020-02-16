using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerStation : MonoBehaviour
{
    ControllerActions controls;
    float detachButton;
    bool isAttach = false;
    public bool isLeftTurret = false;
    public bool isRightTurret = false;
    public float moveSpeed = 5f; //Copied from playerMove, can be changed to change submarine move speed
    public string attachedStation = null;
    public float turretRotateSpeed = 100f;
    private float joystickAngle;
    private float angleModifier;

    void Awake()
    {
        controls = new ControllerActions();
        
    }

    void Start()
    {
        //Set equal to attached status from playerMove
        isAttach = gameObject.GetComponent<playerMove>().isAttached;
    }

    void Update()
    {
        detachButton = controls.Gameplay.Detach.ReadValue<float>();
        isAttach = gameObject.GetComponent<playerMove>().isAttached; //Update isAttach
        if (isAttach && detachButton == 1) //Disconnect from station
        {
            isAttach = false;
            gameObject.GetComponent<playerMove>().isAttached = false;
            isLeftTurret = false;
            isRightTurret = false;
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
                case "TurretStation1":
                    isRightTurret = true;
                    GameObject TurretGun = GameObject.Find("TurretGun1");
                    GameObject TurretBody = GameObject.Find("TurretBody1");

                    joystickAngle = Mathf.Atan2(Input.GetAxis("Vertical"),Input.GetAxis("Horizontal")) * Mathf.Rad2Deg;
                    TurretBody.transform.rotation = Quaternion.AngleAxis(joystickAngle + 90, Vector3.forward);
                    break;
                case "TurretStation2":
                    isLeftTurret = true;
                    TurretGun = GameObject.Find("TurretGun2");
                    TurretBody = GameObject.Find("TurretBody2");

                    joystickAngle = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * Mathf.Rad2Deg;
                    TurretBody.transform.rotation = Quaternion.AngleAxis(joystickAngle - 90, Vector3.forward);
                    break;
            }
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
