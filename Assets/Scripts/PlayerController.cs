using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public ParticleSystem dirtSystem;
    private Animator animPlayer;
    public bool gameOver = false;
  


    // Start is called before the first frame update
    void Start()
    {
        animPlayer = GetComponent<Animator>();
  

    }
    void Update()
    {
        if (gameOver = false)
        {
            animPlayer.SetTrigger("Idle_HandsOnHips");

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                //transform.Rotate(0.0f, 90.0f, 0.0f);
                animPlayer.SetTrigger("Run");
                dirtSystem.Play();


            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                animPlayer.SetTrigger("Run");
                //transform.Rotate(0.0f, -90.0f, 0.0f);
                dirtSystem.Play();


            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * speed * Time.deltaTime;
                animPlayer.SetTrigger("Run");
                dirtSystem.Play();


            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * speed * Time.deltaTime;
                animPlayer.SetTrigger("Run");
                //transform.Rotate(0.0f, 180.0f, 0.0f);
                dirtSystem.Play();


            }
        }
        else
        {
            dirtSystem.Stop();
            animPlayer.SetTrigger("Idle"); 
        }
    }

    
}
