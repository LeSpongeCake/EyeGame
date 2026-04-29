using System.Collections;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{

    public AudioSource myAudioSource;

    public AudioClip[] myAudioClips;

    private PlayerMovement movement;

    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        StartCoroutine(PlayFootSteps());
    }
    IEnumerator PlayFootSteps()
    {
        while (true)
        {
            if (movement.inputVector.magnitude > 0.1f)
            {
                AudioClip randomClip = myAudioClips[Random.Range(0, myAudioClips.Length)];

                myAudioSource.PlayOneShot(randomClip);
            }
            yield return new WaitForSeconds(0.35f);
        }
    }
 
}
