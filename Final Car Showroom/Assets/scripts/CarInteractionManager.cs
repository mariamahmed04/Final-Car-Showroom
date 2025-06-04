using UnityEngine;
using UnityEngine.UI;

public class CarInteractionManager : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    private GameObject currentCar;
    public Material[] carColors;
    private int colorIndex = 0;

    public AudioSource engineSound;

    void Start()
    {
        currentCar = car1;
        car1.SetActive(true);
        car2.SetActive(false);
    }

    public void ChangeColor()
    {
        if (currentCar != null)
        {
            Renderer body = currentCar.transform.Find("Body")?.GetComponent<Renderer>();
            if (body != null && carColors.Length > 0)
            {
                colorIndex = (colorIndex + 1) % carColors.Length;
                body.material = carColors[colorIndex];
            }
        }
    }

    public void ToggleEngine()
    {
        if (engineSound != null)
        {
            if (engineSound.isPlaying)
                engineSound.Stop();
            else
                engineSound.Play();
        }
    }

    public void SwitchCar()
    {
        if (currentCar == car1)
        {
            car1.SetActive(false);
            car2.SetActive(true);
            currentCar = car2;
        }
        else
        {
            car2.SetActive(false);
            car1.SetActive(true);
            currentCar = car1;
        }
    }
}
