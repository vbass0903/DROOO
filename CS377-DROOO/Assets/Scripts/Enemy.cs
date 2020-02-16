using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject en;
    private GameObject sub;
    public GameObject bar;
    public float hitpoints;
    public string nam;

    public Enemy(int hp, string ID) 
    {
        hitpoints = hp;
        nam = ID;
    }
    void Start()
    {

    }

    void Update()
    {
        //en.transform.RotateAround(sub.transform.position, Vector3.back, 20f * Time.deltaTime);
        bar = GameObject.Find("OxygenBar");
        transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ground") || col.CompareTag("Wall")) // enemy hitting ship depletes oxygen
        {
            bar.GetComponent<OxygenBar>().LoseOxy(25f);
            Destroy(gameObject);
        }
    }
}
