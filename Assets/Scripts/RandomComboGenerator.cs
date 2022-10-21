using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomComboGenerator : MonoBehaviour
{
    public GameObject RedTriangle;
    public GameObject RedCircle;
    public GameObject RedSquare;
    public GameObject BlueTriangle;
    public GameObject BlueCircle;
    public GameObject BlueSquare;
    public GameObject YellowTriangle;
    public GameObject YellowCircle;
    public GameObject YellowSquare;

    private string[] colorArr = new string[]{ "Red", "Blue", "Yellow" };
    private string[] shapeArr = new string[]{ "Triangle", "Circle", "Square" };
      
    List<GameObject> yellow = new List<GameObject>();
    List<GameObject> blue = new List<GameObject>();
    List<GameObject> red = new List<GameObject>();
    List<GameObject> triangle = new List<GameObject>();
    List<GameObject> circle = new List<GameObject>();
    List<GameObject> square = new List<GameObject>();

    public string randCombo;

    void Start()
    {

        yellow.Add(YellowTriangle);
        yellow.Add(YellowCircle);
        yellow.Add(YellowSquare);

        blue.Add(BlueTriangle);
        blue.Add(BlueCircle);
        blue.Add(BlueSquare);

        red.Add(RedTriangle);
        red.Add(RedCircle);
        red.Add(RedSquare);

        triangle.Add(RedTriangle);
        triangle.Add(BlueTriangle);
        triangle.Add(YellowTriangle);

        circle.Add(RedCircle);
        circle.Add(BlueCircle);
        circle.Add(YellowCircle);

        square.Add(RedSquare);
        square.Add(BlueSquare);
        square.Add(YellowSquare);

        RandomCombo(); 
    }

    void Update()
    {

    }

    void InstantiateTurn (List <GameObject> color, List<GameObject> shape)
    {
        //shows a random color on the left 
        GameObject randRed = color[Random.Range(0, 3)];
        Instantiate(randRed, new Vector3(-15.3f, randRed.transform.position.y, 2.1f), randRed.transform.rotation);
  
        //shows a random shape on the right
        GameObject randTriangle = shape[Random.Range(0, 3)];
        Instantiate(randTriangle, new Vector3(-4.7f, randTriangle.transform.position.y, 1.9f), randTriangle.transform.rotation);
    }

    //generates random color and shape 
    void RandomCombo() {

        randCombo = colorArr[Random.Range(0, colorArr.Length)] + shapeArr[Random.Range(0, shapeArr.Length)];
        //randCombo = "RedTriangle";
        //prints random color and shape for player
        Debug.Log(randCombo);

        if (randCombo == "RedTriangle")
        {
            InstantiateTurn(red, triangle); 

        }
        if (randCombo == "RedCircle")
        {
            InstantiateTurn(red, circle);

        }
        if (randCombo == "RedSquare")
        {
            InstantiateTurn(red, square);

        }
        if (randCombo == "BlueTriangle")
        {
            InstantiateTurn(blue, triangle);

        }
        if (randCombo == "BlueCircle")
        {
            InstantiateTurn(blue, circle);

        }
        if (randCombo == "BlueSquare")
        {
            InstantiateTurn(blue, square); 

        }
        if (randCombo == "YellowTriangle")
        {
            InstantiateTurn(yellow, triangle); 

        }
        if (randCombo == "YellowCircle")
        {
            InstantiateTurn(yellow, circle); 

        }
        if (randCombo == "YellowSquare")
        {
            InstantiateTurn(yellow, square); 

        }
       
    }

     

    
}

