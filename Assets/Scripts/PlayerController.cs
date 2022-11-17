using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public ParticleSystem dirtSystem;
    private Animator animPlayer;
    //
    public AudioClip correctSound;
    public AudioClip wrongSound;

    private AudioSource asPlayer;

    public GameObject randomCGObject;
    private RandomComboGenerator randomCG;

    public float timeRemaining = 90;
    public bool timerIsRunning = false; 

    public bool gameOver = false;
    int count = 3;


    void Start()
    {

        animPlayer = GetComponent<Animator>();
        //
        randomCGObject = GameObject.Find("RandomComboGenerator");
        randomCG = randomCGObject.GetComponent<RandomComboGenerator>();

        timerIsRunning = true;

        Debug.Log("You have " + timeRemaining + " seconds left!");
        //shortens timer every 45 seconds 
        InvokeRepeating("LessTime", 45.0f, 45.0f);

    }
    void Update()
    {

        

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            //transform.Rotate(0.0f, 90.0f, 0.0f);
            animPlayer.SetTrigger("Run");
            dirtSystem.Play();


        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            animPlayer.SetTrigger("Run");
            //transform.Rotate(0.0f, -90.0f, 0.0f);
            dirtSystem.Play();


        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            animPlayer.SetTrigger("Run");
            dirtSystem.Play();


        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
            animPlayer.SetTrigger("Run");
            //transform.Rotate(0.0f, 180.0f, 0.0f);
            dirtSystem.Play();


        }
        else
        {
            //no button is being pressed
            //!!!!!have player be IDLE
            

           dirtSystem.Stop();
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
    //!!!! make it replay until 0 lives??

    void LessTime()
    {
        timeRemaining = timeRemaining - 5; 
    }
    private void OnCollisionEnter(Collision collision)
    {
        //live counter 
        
        Debug.Log("You have " + count + " lives!");

        // when the player steps on a button on the floor, this checks if it is the correct combo or not 
        if (collision.gameObject.CompareTag(randomCG.randCombo))
        {
            asPlayer.PlayOneShot(correctSound, 1.0f);
            Debug.Log("Next Level!");
        }
        else
        {
            //!!! problem here bc its triggered by everything besides the correct button
            count--;
            Debug.Log("You have " + count + " lives!");
        }

        if(count == 0 || timerIsRunning==false)
        {
            gameOver = true;
            Debug.Log("Game Over!");
            dirtSystem.Stop();
            animPlayer.SetBool("Death_b", true);
            animPlayer.SetInteger("DeathType_int", 2);
            //asPlayer.PlayOneShot(wrongSound, 1.0f);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //power up gives another life 
        if(other.CompareTag("Power Up"))
        {
            Destroy(other.gameObject);
            count++; 
        }
    }

}
