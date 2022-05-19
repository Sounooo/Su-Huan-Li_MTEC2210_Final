using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bullet : MonoBehaviour
{
    private Player player;

    public float speed = 10;
    public float timer = 1f;

    public Vector2 direction = new Vector2(0, 1);

    public Vector2 velocity;


    // Start is called before the first frame update
    void Start()
    {
     
        player = GameObject.Find("Player").GetComponent<Player>();


    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 dir = Vector2.up;
        //Vector3 vel = dir * speed * Time.deltaTime;
        //transform.Translate(vel);

        velocity = direction * speed;
     //  gameObject.GetComponent<AudioSource>().Play();
        Destroy(gameObject, 2.0f);
        

    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos += velocity * Time.fixedDeltaTime;
        transform.position = pos;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            player.UpdateScore(1);

        }       
        
        if (collision.gameObject.tag == "Enemy2")
        {
            Destroy(collision.gameObject);
            player.UpdateScore(2);

        }

        if (collision.gameObject.tag == "Enemy3")
        {
            Destroy(collision.gameObject);
            player.UpdateScore(3);

        }
        if (collision.gameObject.tag == "Enemy4")
        {
            Destroy(collision.gameObject);
            player.UpdateScore(4);

        }
        if (collision.gameObject.tag == "Enemy5")
        {
            Destroy(collision.gameObject);
            player.UpdateScore(5);

        }





        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }


        if (collision.gameObject.tag == "Enemy2")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy3")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy4")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy5")
        {
            Destroy(gameObject);
        }


    }

}




  

