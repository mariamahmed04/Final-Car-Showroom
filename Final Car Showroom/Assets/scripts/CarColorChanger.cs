using UnityEngine;

public class CarColorChanger : MonoBehaviour
{
    public Renderer carBodyRenderer;
    public Material[] colorOptions;
    private int currentColorIndex = 0;

    public void ChangeColor()
    {
        if (colorOptions.Length == 0 || carBodyRenderer == null)
            return;

        currentColorIndex = (currentColorIndex + 1) % colorOptions.Length;
        carBodyRenderer.material = colorOptions[currentColorIndex];
    }
}
