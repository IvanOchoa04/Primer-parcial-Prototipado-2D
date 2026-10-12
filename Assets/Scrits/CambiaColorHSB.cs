using UnityEngine;
using UnityEngine.UI;

public class CambiarColorHSB : MonoBehaviour
{
    [Header("Referencia del Personaje")]
    public SpriteRenderer spriteRendererPersonajeCabeza1;
    public SpriteRenderer spriteRendererPersonajeCabeza2;
    public SpriteRenderer spriteRendererPersonajeCabeza3;
    public SpriteRenderer spriteRendererPersonaje;

    [Header("Sliders HSB (Valores de 0 a 1)")]
    public Slider sliderHue;        // Tono (Hue)
    public Slider sliderSaturation; // Saturación (Saturation)
    public Slider sliderBrightness; // Brillo (Brightness)

    void Start()
    {
       
        if (sliderHue != null) sliderHue.maxValue = 1f;
        if (sliderSaturation != null) sliderSaturation.maxValue = 1f;
        if (sliderBrightness != null)
        {
            sliderBrightness.maxValue = 1f;
            sliderBrightness.value = 1f; 
        }
    }

    void Update()
    {
        if (spriteRendererPersonaje != null && sliderHue != null && sliderSaturation != null && sliderBrightness != null)
        {
            Color colorHSV = Color.HSVToRGB(sliderHue.value, sliderSaturation.value, sliderBrightness.value);
            spriteRendererPersonaje.color = colorHSV;
        }

        if (spriteRendererPersonajeCabeza1 != null && sliderHue != null && sliderSaturation != null && sliderBrightness != null)
        {
            Color colorHSV = Color.HSVToRGB(sliderHue.value, sliderSaturation.value, sliderBrightness.value);
            spriteRendererPersonajeCabeza1.color = colorHSV;
        }

        if (spriteRendererPersonajeCabeza2 != null && sliderHue != null && sliderSaturation != null && sliderBrightness != null)
        {
            Color colorHSV = Color.HSVToRGB(sliderHue.value, sliderSaturation.value, sliderBrightness.value);
            spriteRendererPersonajeCabeza2.color = colorHSV;
        }

        if (spriteRendererPersonajeCabeza3 != null && sliderHue != null && sliderSaturation != null && sliderBrightness != null)
        {
            Color colorHSV = Color.HSVToRGB(sliderHue.value, sliderSaturation.value, sliderBrightness.value);
            spriteRendererPersonajeCabeza3.color = colorHSV;
        }
    }

}