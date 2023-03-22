using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_fire : MonoBehaviour
{
    public Transform firepoint;
    public GameObject CannonBall;
    float timebetween;
    public float starttimebetween;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        timebetween = starttimebetween;
    }



    private void Update()
    {
        if(timebetween <= 0)
        {
            anim.SetTrigger("Shoot");
            Instantiate(CannonBall, firepoint.position, firepoint.rotation);
            timebetween = starttimebetween;
            anim.SetTrigger("Idle");
        }
        else
        {
            timebetween -= Time.deltaTime;
        }
    }
}
