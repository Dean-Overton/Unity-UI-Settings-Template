using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;
    [SerializeField]
    private ToggleController musicToggle;
    public bool musicOn;
    [SerializeField]
    private ToggleController soundToggle;
    public bool soundOn;
    public void ToggleSound ()
    {
        soundOn = soundToggle.isOn;
        if (soundOn)
            audioMixer.SetFloat("SoundVol", 0f);
        else
            audioMixer.SetFloat("SoundVol", -80f);
    }
    public void ToggleMusic()
    {
        musicOn = musicToggle.isOn;
        if (musicOn)
            audioMixer.SetFloat("MusicVol", 0f);
        else
            audioMixer.SetFloat("MusicVol", -80f);
    }
}
