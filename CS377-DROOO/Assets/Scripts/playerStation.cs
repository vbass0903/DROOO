using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerStation : MonoBehaviour
{
    GameObject Player;
    GameObject TurretGun;
    GameObject TurretBody;

    public Rigidbody2D Bullet;
    public Rigidbody2D new_Bullet;

    public float speed;
    public float timeBetweenShots;
    public float timeDestroy;

    bool isAttach = false;
    public bool isLeftTurret = false;
    public bool isRightTurret = false;
    public float moveSpeed = 5f; //Copied from playerMove, can be changed to change submarine move speed
    public string attachedStation = null;
    public float turretRotateSpeed = 70f;
    Vector2 move;

    void Awake()
    {
        
    }

    void Start()
    {
        Player = GameObject.Find("Player");
        speed = 10f;
        timeBetweenShots = 0.5f;
        timeDestroy = 3f;
    }

    void Update()
    {

    }
    
    void FixedUpdate()
    {
        if (isAttach)
        {
            switch (attachedStation)
            {
                case "PilotStation":
                    GameObject submarine = GameObject.Find("Submarine");
                    move = gameObject.GetComponent<playerMove>().move;

                    Vector3 movement = new Vector3(move.x, move.y, 0f);
                    submarine.transform.position += movement * Time.fixedDeltaTime * moveSpeed; //Update position of submarine
                    transform.position += movement * Time.fixedDeltaTime * moveSpeed; //Update player position to stay relevant to sub movement

                    break;
                case "TurretStation1":
                    isRightTurret = true;
                    TurretGun = GameObject.Find("TurretGun1");
                    TurretBody = GameObject.Find("TurretBody1");

                    movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
                    if (movement.x > 0)
                    {
                        TurretGun.transform.RotateAround(TurretBody.transform.position, Vector3.back, turretRotateSpeed * Time.deltaTime);
                    }
                    else if (movement.x < 0)
                    {
                        TurretGun.transform.RotateAround(TurretBody.transform.position, Vector3.forward, turretRotateSpeed * Time.deltaTime);
                    }
                    break;
                case "TurretStation2":
                    isLeftTurret = true;
                    TurretGun = GameObject.Find("TurretGun2");
                    TurretBody = GameObject.Find("TurretBody2");

                    movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
                    if (movement.x > 0)
                    {
                        TurretGun.transform.RotateAround(TurretBody.transform.position, Vector3.back, turretRotateSpeed * Time.deltaTime);
                    }
                    else if (movement.x < 0)
                    {
                        TurretGun.transform.RotateAround(TurretBody.transform.position, Vector3.forward, turretRotateSpeed * Time.deltaTime);
                    }
                    break;
            }
        }
    }

    public void Move(InputAction.CallbackContext context)
    {

    }

    public void Attach(InputAction.CallbackContext context)
    {
        isAttach = true;
    }

    public void Detach(InputAction.CallbackContext context)
    {
        isAttach = false;
        isLeftTurret = false;
        isRightTurret = false;
    }

    public void Fire(InputAction.CallbackContext context)
    {
        if (isAttach && isRightTurret)
        {
            TurretGun = GameObject.Find("TurretGun1");
            TurretBody = GameObject.Find("TurretBody1");

            new_Bullet = Instantiate(Bullet, TurretGun.transform.position, TurretGun.transform.rotation);
            new_Bullet.velocity = -TurretGun.transform.right * speed;
            Destroy(new_Bullet.gameObject, timeDestroy);
        }
        else if (isAttach && isLeftTurret)
        {
            TurretGun = GameObject.Find("TurretGun2");
            TurretBody = GameObject.Find("TurretBody2");

            new_Bullet = Instantiate(Bullet, TurretGun.transform.position, TurretGun.transform.rotation);
            new_Bullet.transform.rotation = TurretGun.transform.rotation * new Quaternion(0, 0, 180, 0);
            new_Bullet.velocity = TurretGun.transform.right * speed;
            Destroy(new_Bullet.gameObject, timeDestroy);
        }
    }
}
