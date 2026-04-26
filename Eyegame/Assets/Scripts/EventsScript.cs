using NUnit.Framework;
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
        Sound_Manager.PlaySound(SoundType.CollectSound);
    }
    
}
