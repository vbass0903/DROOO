using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject oxyBar;
    public float oxyGain = 50f;
    void Start()
    {

    }
    void Update()
    {
        bullet = GameObject.Find("Bullet(Clone)");
        oxyBar = GameObject.Find("OxygenBar");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().rotateRate += 10;
            oxyBar.GetComponent<OxygenBar>().GainOxy(oxyGain);
            Destroy(bullet);
        }

    }

}
