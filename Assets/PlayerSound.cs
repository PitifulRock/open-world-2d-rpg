using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    AudioSource PlayerAudio;

    public AudioClip footstepSound;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAudio = GetComponent<AudioSource>();
    }

    public void PlayFootstep()
    {
        PlayerAudio.clip = footstepSound;
        PlayerAudio.Play();
    }
}
