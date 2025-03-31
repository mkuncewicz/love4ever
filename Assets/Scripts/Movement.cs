using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float x;
    public float z;

    AudioSource steps;

    public Animator cameraAnimator;

    void Start()
    {
         steps = gameObject.GetComponent<AudioSource>();
    }

   
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        player.Translate(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime);

        if (x != 0 || z != 0)
        {
            steps.volume = 0.5f;
            cameraAnimator.SetInteger("walk", 1);
        }
        else {
            steps.volume = 0f;
            cameraAnimator.SetInteger("walk", 0);
        }
    }   
}
