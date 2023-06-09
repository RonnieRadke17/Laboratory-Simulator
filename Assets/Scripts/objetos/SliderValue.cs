using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//libreria necesaria para usar el slider 
using TMPro;
public class SliderValue : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI valueText;

    private void Update()
    {
        float sliderValue = slider.value;
        valueText.text = sliderValue.ToString();
    }
}