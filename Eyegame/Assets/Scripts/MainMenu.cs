using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame()
    {  
        Application.Quit();
    }


    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume",volume);
    }

    public void SetFullscreen (bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }
}
