using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject en;
    private GameObject sub;
    public float hitpoints;
    public string nam;
    public float rotateRate = 20f;

    public Enemy(int hp, string ID) //Constructor
    {
        hitpoints = hp;
        nam = ID;
    }
    void Start()
    {

    }

    void Update()
    {
        // pretty sure theres a faster way to make this work so just use for testing purposes
        en = GameObject.Find("Enemy");
        sub = GameObject.Find("Submarine");
        en.transform.RotateAround(sub.transform.position, Vector3.back, rotateRate * Time.deltaTime);
    }

}
