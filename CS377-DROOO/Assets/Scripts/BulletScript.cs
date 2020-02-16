using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bar;
    public float oxyGain = 50f;
    void Start()
    {

    }
    void Update()
    {
        bullet = GameObject.Find("Bullet(Clone)");
        bar = GameObject.Find("OxygenBar");
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            //collision.gameObject.GetComponent<Enemy>().rotateRate += 10;
            bar.GetComponent<OxygenBar>().LoseOxy(oxyGain);
            Destroy(gameObject);
        }
        if (col.CompareTag("Ground") || col.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (col.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }


    }

}
