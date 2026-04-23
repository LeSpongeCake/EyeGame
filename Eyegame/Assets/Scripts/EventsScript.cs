using UnityEngine;
using UnityEngine.SceneManagement;

public class EventsScript : MonoBehaviour
{
    public GameObject Target;
    public void LoadScene()
    {
        SceneManager.LoadScene("SpookyScene");
    }

    public void Delete()
    {
        Target.SetActive(false);
    }
    
}
