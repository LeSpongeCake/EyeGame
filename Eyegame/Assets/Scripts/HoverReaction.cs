using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using NUnit.Framework;
using UnityEngine.Events;
public class HoverReaction : MonoBehaviour
{
    
    public UnityEngine.UI.Image fillBar;
    public UnityEvent onEvent;

    public float fillSpeed;
    public bool full;
    public int type;

    public bool isHover;

    public SpriteRenderer warningBorder;
    void Update()
    {
        if (fillBar == null) return;

        if (isHover)
        {
            fillBar.fillAmount = Mathf.Clamp01(fillBar.fillAmount + fillSpeed * Time.deltaTime);
        }

        else if (isHover == false && full == false)
        {
            fillBar.fillAmount = Mathf.Clamp01(fillBar.fillAmount - fillSpeed * Time.deltaTime);
        }

        if (fillBar.fillAmount >= 1 && !full)
        {
            full = true;
            onEvent.Invoke();

            fillBar.fillAmount = 0;
            full = false;
        }

        if (type == 1 && warningBorder != null)
        {
            Color c = warningBorder.color;

            if (isHover)
                c.a = fillBar.fillAmount / 2;
            else
                c.a = Mathf.Lerp(c.a, 0, Time.deltaTime * 10f); 

            warningBorder.color = c;
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isHover = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isHover = false;
        }
    }
}
