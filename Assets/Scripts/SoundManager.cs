using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public SoundManager Instance = null;

    public AudioClip alienBuzz1;
    public AudioClip alienBuzz2;
    public AudioClip alienDies;
    public AudioClip bulletFire;
    public AudioClip shipExplosion;

    private AudioSource soundEffect;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        AudioSource theSound = GetComponent<AudioSource>();
        soundEffect = theSound;
    }

    public void PlayOneShot(AudioClip clip)
    {
        soundEffect.PlayOneShot(clip);
    }
}
