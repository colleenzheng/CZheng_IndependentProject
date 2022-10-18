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
        Instantiate(randRed, new Vector3(0f, randRed.transform.position.y, 5f), randRed.transform.rotation);
  
        //shows a random shape on the right
        GameObject randTriangle = shape[Random.Range(0, 3)];
        Instantiate(randTriangle, new Vector3(0f, randTriangle.transform.position.y, -5f), randTriangle.transform.rotation);
    }

    //generates random color and shape 
    void RandomCombo() {

        randCombo = colorArr[Random.Range(0, colorArr.Length)] + shapeArr[Random.Range(0, shapeArr.Length)];
        randCombo = "RedTriangle";
        //prints random color and shape for player
        Debug.Log(randCombo);

        if (randCombo == "RedTriangle")
        {
            InstantiateTurn(red, triangle); 

        }
        if (randCombo == "RedCircle")
        {
            GameObject randRed = red[Random.Range(0, 3)];
            Instantiate(randRed, new Vector3(0f, randRed.transform.position.y, 5f), randRed.transform.rotation);
            GameObject randCircle = circle[Random.Range(0, 3)];
            Instantiate(randCircle, new Vector3(0f, randCircle.transform.position.y, -5f), randCircle.transform.rotation);

        }
        if (randCombo == "RedSquare")
        {
            GameObject randRed = red[Random.Range(0, 3)];
            Instantiate(randRed, new Vector3(2, 0, 7.5f), Quaternion.identity);
            GameObject randSquare = square[Random.Range(0, 3)];
            Instantiate(randSquare, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "BlueTriangle")
        {
            GameObject randBlue = blue[Random.Range(0, 3)];
            Instantiate(randBlue, new Vector3(2, 0, 7.5f), Quaternion.identity);
            GameObject randTriangle = triangle[Random.Range(0, 3)];
            Instantiate(randTriangle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "BlueCircle")
        {
            GameObject randBlue = blue[Random.Range(0, 3)];
            Instantiate(randBlue, new Vector3(2, 0, 7.5f), Quaternion.identity);
            GameObject randCircle = circle[Random.Range(0, 3)];
            Instantiate(randCircle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "BlueSquare")
        {
            GameObject randBlue = blue[Random.Range(0, 3)];
            Instantiate(randBlue, new Vector3(2, 0, 7.5f), Quaternion.identity);
            GameObject randSquare = square[Random.Range(0, 3)];
            Instantiate(randSquare, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "YellowTriangle")
        {
            GameObject randYellow = yellow[Random.Range(0, 3)];
            Instantiate(randYellow, new Vector3(2, 0, 7.5f), Quaternion.identity);
            GameObject randTriangle = triangle[Random.Range(0, 3)];
            Instantiate(randTriangle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "YellowCircle")
        {
            GameObject randYellow = yellow[Random.Range(0, 3)];
            Instantiate(randYellow, new Vector3(2, 0, 7.5f), Quaternion.identity);
            GameObject randCircle = circle[Random.Range(0, 3)];
            Instantiate(randCircle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "YellowSquare")
        {
            GameObject randYellow = yellow[Random.Range(0, 3)];
            Instantiate(randYellow, new Vector3(2, 0, 7.5f), Quaternion.identity);
            GameObject randSquare = square[Random.Range(0, 3)];
            Instantiate(randSquare, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
       
    }

     

    
}

