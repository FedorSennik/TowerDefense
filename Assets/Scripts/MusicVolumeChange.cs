using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeChange : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider; 

    void Start()
    {
        volumeSlider.value = audioSource.volume;

        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
