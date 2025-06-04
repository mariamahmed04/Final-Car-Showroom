using UnityEngine;

public class CarColorChanger : MonoBehaviour
{
    public Material targetMaterial;            // The material instance on the car
    public Material[] colorOptions;            // Swappable material variants
    private int currentColorIndex = 0;

    public void ChangeColor()
    {
        if (colorOptions.Length == 0 || targetMaterial == null)
            return;

        currentColorIndex = (currentColorIndex + 1) % colorOptions.Length;
        // Copy the new color to the existing material instance
        targetMaterial.color = colorOptions[currentColorIndex].color;
    }
}
