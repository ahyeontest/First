using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    TextMeshProUGUI text;
    int score = 0;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void ScoreUp(int number)
    {
        score += number;
        text.text = "Score : " + score;
    }
}
