using System;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera moveCamera;
    public GameObject targetObject;

    void Update()
    {
        Vector3 screenPos = moveCamera.WorldToScreenPoint(targetObject.transform.position);
        Vector3 pos = moveCamera.transform.position;

        if (screenPos.y > Screen.height - 100f)
        {
            pos.y += 3f * Time.deltaTime;
        }

        if (screenPos.y < 100f)
        {
            pos.y -= 3f * Time.deltaTime;   
        }

        pos.y = Mathf.Clamp(pos.y, 0f, 10f);
        moveCamera.transform.position = pos;
    }
}
