using UnityEngine;

public class CarSwitcher : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;

    private GameObject currentCar;

    void Start()
    {
        car1.SetActive(true);
        car2.SetActive(false);
        currentCar = car1;
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

    public GameObject GetCurrentCar()
    {
        return currentCar;
    }
}
