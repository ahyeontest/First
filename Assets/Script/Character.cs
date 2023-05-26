using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject winImg;
    public GameObject loseImg;
    
    public float moveSpeed = 1f;
    [SerializeField]
    private float jumpPower = 500f;
    [SerializeField]
    private GameManager gameManager;

    Rigidbody2D rigid;
    AudioSource audio;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        print("character awake");
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * GameManager.Instance.BonusSpeed * Time.deltaTime);
        transform.Translate(1, 2, 3*Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            audio.Play();
            rigid.AddForce(Vector2.up * jumpPower);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Win")
        {
            gameManager.Win();
            winImg.SetActive(true);
        } 
        else if (collision.gameObject.name == "Lose")
        {
            gameManager.Lose();
            loseImg.SetActive(true);
        }
    }
}
