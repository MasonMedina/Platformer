﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int cheese = 0;

    [SerializeField] private Text cheeseCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cheese"))
        {
            Destroy(collision.gameObject);
            cheese++;
            cheeseCount.text = ""+ cheese;
        }
    }
}
