/*using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public Sound[] sound;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Sound s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.loop = s.loop;
            s.source.volume = s.volume;
            s.source.clip = s.clip;
        }

        PlaySound("Theme");
    }

    public void PlaySound(string name)
    {
        foreach (Sound s in sound)
        {
            if (s.name == name)
            {
                s.source.Play();
                Debug.Log("PlayingAudio: " + name);
            }
        }
    }
}*/