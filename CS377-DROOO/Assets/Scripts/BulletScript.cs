using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {

    }
    void Update()
    {
        bullet = GameObject.Find("Bullet(Clone)");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().rotateRate += 10;
        }

    }

}
