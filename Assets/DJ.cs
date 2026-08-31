using UnityEngine;
using UnityEngine.Audio;

public class DJ : MonoBehaviour
{
    public AudioMixer masterMixer;

    public void SetVol(float vol)
    {
        masterMixer.SetFloat("masterVol", Mathf.Log10(vol) * 20);
    }
}
