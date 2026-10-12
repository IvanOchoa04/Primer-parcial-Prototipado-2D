using UnityEngine;
using UnityEngine.UI;


public class ColorearSlidersHSB : MonoBehaviour
{
    [Header("Referencias de los Sliders")]
    public Slider sliderHue;
    public Slider sliderSaturation;
    public Slider sliderBrightness;

    void Update()
    {
        ActualizarBarraHue();
        ActualizarBarraSaturation();
        ActualizarBarraBrightness();
    }

    void ActualizarBarraHue()
    {
        if (sliderHue == null) return;

       
        Image fillImage = sliderHue.fillRect?.GetComponent<Image>();
        if (fillImage != null)
        {
            fillImage.color = Color.HSVToRGB(sliderHue.value, 1f, 1f);
        }
    }

    void ActualizarBarraSaturation()
    {
        if (sliderSaturation == null || sliderHue == null) return;

        Image fillImage = sliderSaturation.fillRect?.GetComponent<Image>();
        if (fillImage != null)
        {
            Color colorMin = Color.HSVToRGB(sliderHue.value, 0f, sliderBrightness ? sliderBrightness.value : 1f);
            Color colorMax = Color.HSVToRGB(sliderHue.value, 1f, sliderBrightness ? sliderBrightness.value : 1f);

         
            fillImage.color = Color.Lerp(colorMin, colorMax, sliderSaturation.value);
        }
    }

    void ActualizarBarraBrightness()
    {
        if (sliderBrightness == null || sliderHue == null) return;

        Image fillImage = sliderBrightness.fillRect?.GetComponent<Image>();
        if (fillImage != null)
        {
           
            Color colorMin = Color.HSVToRGB(sliderHue.value, sliderSaturation ? sliderSaturation.value : 1f, 0f);
            Color colorMax = Color.HSVToRGB(sliderHue.value, sliderSaturation ? sliderSaturation.value : 1f, 1f);

            fillImage.color = Color.Lerp(colorMin, colorMax, sliderBrightness.value);
        }
    }
}
