using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderExerciseHp : MonoBehaviour
{
    [SerializeField]
    private Slider sliderHp;

    [SerializeField]
    private TextMeshProUGUI textHp;

    [SerializeField]
    private SpriteRenderer starRenderer;

    [SerializeField]
    private Button buttonAttack;

    private float maxHp = 100;
    private float currentHp;
    private float damage = 12;

    private void Awake()
    {
        currentHp = maxHp;
    }

    public void OnClickEventAttack()
    {
        if (currentHp > 0)
        {
            //1. 체력을 damage만큼 차감
            currentHp -= damage;
            currentHp = Mathf.Max(currentHp, 0);
            //2. Slider Fill 변경
            sliderHp.value = currentHp / maxHp;
            //3. Text 변경
            textHp.text = $"{currentHp}/{maxHp}";
            //4. Star 빨간색으로 깜빡이도록 
            StartCoroutine("ColorAnimation");
        } 
        else
        {
            //버튼 비 활성화
            buttonAttack.interactable = false;
        }
    }

    private IEnumerator ColorAnimation()
    {
        starRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        starRenderer.color = Color.white;
    }

    public void OnSliderEventAlpha(float value)
    {
        Color color = starRenderer.color;
        color.a = value;
        starRenderer.color = color;

        textHp.text = $"Alpha : {value * 255:F0}";
    }
}
