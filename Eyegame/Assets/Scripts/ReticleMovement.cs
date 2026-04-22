using UnityEngine;
using UnityEngine.InputSystem;

public class ReticleMovement : MonoBehaviour
{
    public GameObject reticle;
    
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        reticle.transform.position = new Vector3(mousePos.x, mousePos.y, mousePos.y);
    }
}
