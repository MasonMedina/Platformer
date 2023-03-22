using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChange : MonoBehaviour
{
    private Animator anim;
    private bool inDoor;
    private bool opened = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetButtonDown("Up")  && inDoor && !opened)
        {
            anim.SetTrigger("DoorOpen");
            opened = true;
            StartCoroutine(delay());
            
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inDoor = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inDoor = false;

        }
    }
}
