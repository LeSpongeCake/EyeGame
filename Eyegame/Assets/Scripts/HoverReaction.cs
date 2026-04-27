using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using NUnit.Framework;
public class HoverReaction : MonoBehaviour
{
    
    public UnityEngine.UI.Image fillBar;

    public float fillSpeed;
    public bool full;
    public int type;

    public bool isHover;
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

        if (fillBar.fillAmount == 1)
        {
            full = true;
        }

        if (full)
        {
            
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
