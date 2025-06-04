using UnityEngine;

public class EngineToggle : MonoBehaviour
{
    public AudioSource engineAudio;
    private bool isEngineOn = false;

    public void ToggleEngine()
    {
        if (engineAudio == null) return;

        isEngineOn = !isEngineOn;
        if (isEngineOn)
            engineAudio.Play();
        else
            engineAudio.Stop();
    }
}
