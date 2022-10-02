using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject arena; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RotateBoard", 90.0f, 90.0f);
    }

    // Update is called once per frame
    void RotateBoard()
    {
        gameObj.transform.arena = new Vector3(
            gameObj.transform.arena.x,
            gameObj.transform.arena.y + 90,
            gameObj.transform.arena.z
        );
    }
}
