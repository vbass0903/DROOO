using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerUI : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public bool isTouching = false;

    void Start()
    {
        Hide();
    }

    void Update()
    {
        if (isTouching)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    void Hide()
    {
        canvasGroup.alpha = 0f; //this makes everything transparent
        canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
    }

    void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
}
