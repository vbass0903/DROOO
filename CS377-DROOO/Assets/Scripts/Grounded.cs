using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision) //Once player touches ground set isGrounded = true
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<playerMove>().isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision) //Once player leaves ground set isGrounded = false
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<playerMove>().isGrounded = false;
        }
    }
}
