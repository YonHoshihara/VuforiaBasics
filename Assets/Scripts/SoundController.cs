using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    private AudioSource m_AudioSource;
    private void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        m_AudioSource.Play();
    }

    public void PauseSound()
    {
        m_AudioSource.Pause();
    }
}
