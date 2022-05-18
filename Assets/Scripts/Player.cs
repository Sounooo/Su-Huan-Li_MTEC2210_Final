using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;
    public int Health;
    public GameObject HpBar;
    public GameObject bulletPrefab;
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    private int score;
    public TextMeshProUGUI scoreText;

    public GameObject RestarButton;

    void Start()
    {
        Health = 3;
        score = 0;
        UpdateScore(0);

    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;

        transform.Translate(xMovement, yMovement, 0);

        cooldownTimer -= Time.deltaTime;



        if (Input.GetKeyDown(KeyCode.Space) && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            ModifyHealth(-1);
            Destroy(collision.gameObject);


        }
        if (collision.gameObject.tag == "Enemy2")
        {
            ModifyHealth(-1);
            Destroy(collision.gameObject);


        }
        if (collision.gameObject.tag == "Enemy3")
        {
            ModifyHealth(-1);
            Destroy(collision.gameObject);


        }
        if (collision.gameObject.tag == "Enemy4")
        {
            ModifyHealth(-1);
            Destroy(collision.gameObject);


        }
        if (collision.gameObject.tag == "Enemy5")
        {
            ModifyHealth(-1);
            Destroy(collision.gameObject);


        }
        void ModifyHealth(int num)
        {
            Health += num;
            if (Health > 3)
            {
                Health = 3;
            }
            else if (Health <= 0)
            {
                Health = 0;
                Lose();
                
                //Time.timeScale = 0f;
                //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            UpdateHpBar();
        }
        void UpdateHpBar()
        {
            for (int i = 0; i < HpBar.transform.childCount; i++)
            {
                if (Health > i)
                {
                    HpBar.transform.GetChild(i).gameObject.SetActive(true);
                }
                else
                {
                    HpBar.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }

    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }

    private void Lose()
    {
    Time.timeScale = 0f;
    RestarButton.SetActive(true);
    }
    public void Restart()
{
    Time.timeScale = 1f;
    
     SceneManager.LoadScene("Final");
    }
}


