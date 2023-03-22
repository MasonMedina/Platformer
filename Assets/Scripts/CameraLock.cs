using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private int y_offset;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y+y_offset, transform.position.z);
    }
}