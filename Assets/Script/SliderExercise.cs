using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SliderExercise : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private TextMeshProUGUI textAlpha;

    [SerializeField]
    private SpriteRenderer starRenderer;

    public void OnSliderEvent(float value)
    {
        text.text = $"Volume {value*100:F1}%";
    }

    public void OnSliderEventAlpha(float value)
    {
        Color color = starRenderer.color;
        color.a = value;
        starRenderer.color = color;

        textAlpha.text = $"Alpha : {value * 255:F0}";
    }
}
