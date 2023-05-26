using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleExercise : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    public void OnValueChangedToggleEvent01(bool isOn)
    {
        player.SetActive(isOn);
        Debug.Log($"Toggle key {isOn}");
    }

    public void OnValueChangedToggleEvent02()
    {
        Debug.Log($"Toggle key");
    }
}
