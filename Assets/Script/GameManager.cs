using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    static int _bonusSpeed;

    public int BonusSpeed
    {
        get => _bonusSpeed;
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            _bonusSpeed = 1;
            DontDestroyOnLoad(gameObject);
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        Time.timeScale = 1;
    }
    
    public void Win()
    {
        _bonusSpeed *= 2;
        Time.timeScale = 0;
    }

    public void Lose()
    {
        Debug.Log("Lose");
        _bonusSpeed = 1;
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene("Play");
        Time.timeScale = 1;
    }
}
