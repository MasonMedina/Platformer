using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hearts : MonoBehaviour
{

    private int health = 3;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    private Rigidbody2D rb;
    private Animator anim;
    public string scene_name;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("CannonBall"))
        {
            health--;

            if (health == 2)
            {
                Destroy(Heart3.gameObject);
            }

            if (health == 1)
            {
                Destroy(Heart2.gameObject);
            }

            if (health == 0)
            {
                Destroy(Heart1.gameObject);
                rb.bodyType = RigidbodyType2D.Static;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Spike"))
        {

            Destroy(Heart3.gameObject);
            Destroy(Heart2.gameObject);
            Destroy(Heart1.gameObject);
            rb.bodyType = RigidbodyType2D.Static;
            System.Threading.Thread.Sleep(50);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }


    }

    void Update()
    {
    
        

       
           
        
    }
}


