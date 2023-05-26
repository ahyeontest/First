using UnityEngine;
using TMPro;

public class PasswordManager : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;

    [SerializeField]
    private TextMeshProUGUI text;

    public void OnValueChangedEvent()
    {
        text.text = "�Է� ��...";
    }

    public void OnEndEditEvent()
    {
        if (inputField.text.Equals("1234"))
        {
            text.text = "Login!";
        }
        else
        {
            text.text = "Fail!";
        }
    }

    public void OnSelectEvent()
    {
        text.text = "����...";
    }

    public void OnDeselectEvent()
    {
        text.text = "�̼���...";
    }

}
