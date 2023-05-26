using UnityEngine;
using TMPro;

public class DropdownExcercise : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    public void OnValueChanged(int index)
    {
        text.text = $"Dropdown Index : {index}";
    }
}
