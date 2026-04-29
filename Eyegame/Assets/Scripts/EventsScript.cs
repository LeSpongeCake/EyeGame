using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventsScript : MonoBehaviour
{
    public GameObject Target;
    public Camera mainCamera;
    public void LoadScene()
    {
        SceneManager.LoadScene("SpookyScene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("SpookyScene 2");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("supermarket 2");
    }

    
    public void Delete()
    {
        Sound_Manager.PlaySound(SoundType.CollectSound);
        Target.SetActive(false);
    }

    public void ResetCamera()
    {
        UnityEngine.Vector3 pos = mainCamera.transform.position;
        pos.x = 0;
        pos.y = 0;
        mainCamera.transform.position = pos;
    }

    public void Enable()
    {
        Target.SetActive(true);
    }

    public void EndScene()
    {
        SceneManager.LoadScene("EndScene");
    }
    
}
