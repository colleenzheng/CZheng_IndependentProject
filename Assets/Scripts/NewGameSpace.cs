using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpace : MonoBehaviour
{
    public string spaceType;
    public GameObject randomCGObject;
    private RandomComboGenerator randomCG;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource asPlayer;

    private Animator animPlayer;

    public bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        randomCGObject = GameObject.Find("RandomComboGenerator");
        randomCG = randomCGObject.GetComponent<RandomComboGenerator>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        // when the player steps on a button on the floor, this checks if it is the correct combo or not 
        if (other.gameObject.name == "Player" && spaceType == randomCG.randCombo)
        {
            asPlayer.PlayOneShot(jumpSound, 1.0f);
            Debug.Log("Next Level!");
            //      RandomComboGenerator();

        }
        else
        {
            gameOver = true;
            Debug.Log("Game Over!!!");

            //animPlayer.SetBool("Death_b", true);
            //animPlayer.SetInteger("DeathType_int", 2);
            //asPlayer.PlayOneShot(crashSound, 1.0f);
        }
    }

}