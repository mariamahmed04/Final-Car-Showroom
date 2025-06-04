using UnityEngine;

public class EngineToggle : MonoBehaviour
{
    public AudioSource engineAudio;
    private bool isOn = false;

    public void ToggleEngine()
    {
        isOn = !isOn;
        if (isOn)
            engineAudio.Play();
        else
            engineAudio.Stop();
    }
}
