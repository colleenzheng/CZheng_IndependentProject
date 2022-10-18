using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpace : MonoBehaviour
{
    public string spaceType;
    public GameObject randomCGObject;
    private RandomComboGenerator randomCG; 

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
            Debug.Log("Next Level!");
      //      RandomComboGenerator();

        }
        else
        {
            Debug.Log("Game Over!");
        }
    }

}
