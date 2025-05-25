using UnityEngine;
using UnityEngine.Audio;

public class SoundMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    void Start()
    {
        SetMasterVolume(PlayerPrefs.GetFloat("MasterVolume"));
        SetSoundFXVolume(PlayerPrefs.GetFloat("SoundFXVolume"));
        SetMusicVolume(PlayerPrefs.GetFloat("MusicVolume"));
    }

    public void SetMasterVolume(float level)
    {
        audioMixer.SetFloat("MasterVolume", level);
        PlayerPrefs.SetFloat("MasterVolume", level);
        // set player pref then in start in the sample scene call to use playerpref
    }

    public void SetSoundFXVolume(float level)
    {
        audioMixer.SetFloat("SoundFXVolume", level);
        PlayerPrefs.SetFloat("SoundFXVolume", level);
    }

    public void SetMusicVolume(float level)
    {
        audioMixer.SetFloat("MusicVolume", level);
        PlayerPrefs.SetFloat("MusicVolume", level);
    }
}
