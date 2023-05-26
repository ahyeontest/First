using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public Button winBtn;
    public Button logBtn;

    private void Awake()
    {
        winBtn.onClick.AddListener(Replay);
        logBtn.onClick.AddListener(Replay);
    }

    public void Replay()
    {
        GameManager.Instance.Replay();
    }
}
