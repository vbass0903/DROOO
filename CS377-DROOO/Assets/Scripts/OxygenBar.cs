using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenBar : MonoBehaviour
{
    public GameObject bar;
    public float oxygenDepleteRate = 0.3f;
    public float oxygenLevel;
    public void Start()
    {
        GameObject bar = GameObject.Find("Bar");
        oxygenLevel = bar.transform.localScale.x;
    }

    public void DecreaseOxy(float change)
    {
        bar.transform.localScale = new Vector2(bar.transform.localScale.x - change, bar.transform.localScale.y);
        oxygenLevel -= change;
    }

    public void GainOxy(float change)
    {
        bar.transform.localScale = new Vector2(bar.transform.localScale.x + change, bar.transform.localScale.y);
        oxygenLevel += change;
    }
    
    public void LoseOxy(float change)
    {
        bar.transform.localScale = new Vector2(bar.transform.localScale.x - change, bar.transform.localScale.y);
        oxygenLevel -= change;
    }

    private void ChangeColor(Color color)
    {
        bar.GetComponent<SpriteRenderer>().color = color;
    }

    public void FixedUpdate() 
    {
        DecreaseOxy(oxygenDepleteRate); // idk if this needs to be in update or fixedupdate
    }

    public void Update()
    {
        if(oxygenLevel < 0)
        {
            oxygenLevel = 0; // and you lose!
            bar.transform.localScale = new Vector2(0, bar.transform.localScale.y);
        }
        if(oxygenLevel > 352) // 352 is max localScale,  CHANGES IF GAME SCALE CHANGES
        {
            oxygenLevel = 352;
            bar.transform.localScale = new Vector2(352, bar.transform.localScale.y);
        }
    }
}
