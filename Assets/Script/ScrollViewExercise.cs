using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScrollViewExercise : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    public void OnScrollViewEvent(Vector2 position)
    {
        text.text = $"Scrollbar Position : {position}";
    }
}
