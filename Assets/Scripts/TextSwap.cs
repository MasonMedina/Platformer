using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSwap : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite swapText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteRenderer.sprite = swapText;

        }
    }
}
