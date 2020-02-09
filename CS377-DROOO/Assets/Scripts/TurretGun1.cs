using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurretGun1 : MonoBehaviour
{
    GameObject Player;
    GameObject Turret;
    GameObject Body;

    ControllerActions controls;

    public Rigidbody2D Bullet;
    public Rigidbody2D new_Bullet;

    public float speed;
    public float timeBetweenShots;
    public float timeDestroy;

    void Awake()
    {
        controls = new ControllerActions();
        controls.Gameplay.TurretFire.started += ctx => Fire();
    }

    void Start()
    {
        Player = GameObject.Find("Player");
        Turret = GameObject.Find("TurretGun1");
        Body = GameObject.Find("TurretBody1");

        speed = 10f;
        timeBetweenShots = 0.5f;
        timeDestroy = 3f;
    }

    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground")){
            Turret.transform.RotateAround(Body.transform.position, Vector3.forward, 100f * Time.deltaTime);
        }
        if (collision.CompareTag("Wall"))
        {
            Turret.transform.RotateAround(Body.transform.position, Vector3.back, 100f * Time.deltaTime);
        }

    }

    void Fire()
    {
        if (Player.GetComponent<playerMove>().isAttached && Player.GetComponent<playerStation>().isRightTurret)
        {
            new_Bullet = Instantiate(Bullet, Turret.transform.position, Turret.transform.rotation);
            new_Bullet.velocity = -transform.right * speed;
            Destroy(new_Bullet.gameObject, timeDestroy);
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