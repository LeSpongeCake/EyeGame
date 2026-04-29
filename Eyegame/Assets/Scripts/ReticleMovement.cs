using UnityEngine;
using UnityEngine.InputSystem;

public class ReticleMovement : MonoBehaviour
{
    public GameObject reticle;
    public float moveSpeed;
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 targetpos = new Vector3(mousePos.x, mousePos.y, 0);
        reticle.transform.position = Vector3.Lerp(reticle.transform.position, targetpos, moveSpeed * Time.deltaTime);
    }
}