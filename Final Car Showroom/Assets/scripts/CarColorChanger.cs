using UnityEngine;

public class CarColorChanger : MonoBehaviour
{
    public Renderer bodyRenderer;
    public Material[] bodyMaterials;
    private int index = 0;

    public void ChangeColor()
    {
        if (bodyMaterials.Length == 0) return;
        index = (index + 1) % bodyMaterials.Length;
        bodyRenderer.material = bodyMaterials[index];
    }
}
