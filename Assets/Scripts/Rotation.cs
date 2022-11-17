using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject arena; 

    void Start()
    {
        InvokeRepeating("RotateBoard", 90.0f, 90.0f);
    }

    void RotateBoard()
    {
        arena.transform.position = new Vector3(0, 90, 0); 
    }
}
