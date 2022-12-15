using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public float timeRemaining = 6;
    public bool timerIsRunning = false; 

    public bool gameOver = false;

    public float turnSpeed = 100f;

    public TextMeshProUGUI liveText;
    private int count = 3;

    public TextMeshProUGUI gameOverText;
    public bool gameActive = true;

    public Button restartButton;
    public Button startButton;
    public GameObject titleScreen;
  
    void Start()
    {
        liveText.text = "LIVES: " + count;

        titleScreen.gameObject.SetActive(true);

        animPlayer = GetComponent<Animator>();
        
        randomCGObject = GameObject.Find("RandomComboGenerator");
        randomCG = randomCGObject.GetComponent<RandomComboGenerator>();

        timerIsRunning = true;

        Debug.Log("You have " + timeRemaining + " seconds left!");
        //slows speed every 2 seconds 
        InvokeRepeating("SlowSpeed", 2.0f, 2.0f);
        if (count > 0)
        {
            InvokeRepeating("addLife", 2.0f, 4.0f);
        }
    }
    public void addLife()
    {
        count -= 1;
        liveText.text = "LIVES: " + count;

    }
    public void UpdateLives(int liveDelta)
    {
        count += liveDelta;
        liveText.text = "LIVES: " + count;
    } 
    public void GameOver()
    {
        gameActive = false; 
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");
        if (count == 0)
        {
            GameOver();
        }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                //transform.Rotate(Vector3.up*horizontalInput*turnSpeed*Time.deltaTime);
                animPlayer.SetTrigger("Run");
                dirtSystem.Play();


            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                //transform.Rotate(Vector3.up * -horizontalInput * turnSpeed * Time.deltaTime);
                animPlayer.SetTrigger("Run");
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
                    Debug.Log("You have " + count + " lives!");
                }
            }
    }

    void SlowSpeed()
    {
        if (speed >= 0)
        {
            speed = speed-1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // when the player steps on a button on the floor, this checks if it is the correct combo or not 
        if (collision.gameObject.CompareTag(randomCG.randCombo))
        {
            asPlayer.PlayOneShot(correctSound, 1.0f);
            Debug.Log("Next Level!");
        }

        if (count==0&&timerIsRunning==false)
        {
            liveText.text = "Lives: 0";
            gameOver = true;
            GameOver();
            dirtSystem.Stop();
            animPlayer.SetBool("Death_b", true);
            animPlayer.SetInteger("DeathType_int", 2);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //power up gives another life 
        if(other.CompareTag("Power Up"))
        {
            Destroy(other);
            UpdateLives(1);
        }
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        gameActive = true;
        titleScreen.gameObject.SetActive(false);
    }
}
