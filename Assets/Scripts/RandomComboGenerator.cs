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

    public string[] colorArr = new string[]{ "Red", "Blue", "Yellow" };
    public string[] shapeArr = new string[]{ "Triangle", "Circle", "Square" };


    //string[] colorArr = new string[3] { "Red", "Blue" , "Yellow" };
    //string[] shapeArr = new string[3] { "Triangle", "Circle" , "Square" };


    List<GameObject> yellow;       
    yellow.Add(new GameObject); 
    yellow.Add(YellowCircle);
    yellow.Add(YellowSquare); 
    List<GameObject> blue = new List<GameObject>();
    blue.Add(BlueTriangle);
    blue.Add(BlueCircle);
    blue.Add(BlueSquare);
    List<GameObject> red = new List<GameObject>();
    red.Add(RedTriangle); 
    red.Add(RedCircle);
    red.Add(RedSquare);
    List<GameObject> triangle = new List<GameObject>();
    triangle.Add(RedTriangle);
    triangle.Add(BlueTriangle);
    triangle.Add(YellowTriangle);
    List<GameObject> circle = new List<GameObject>();
    circle.Add(RedCircle);
    circle.Add(BlueCircle); 
    circle.Add(YellowCircle); 
    List<GameObject> square = new List<GameObject>();
    square.Add(RedSquare);
    square.Add(BlueSquare); 
    square.Add(YellowSquare);


    void Start()
    {
        RandomCombo();
    }

    void Update()
    {

    }

    //generates random color and shape 
    void RandomCombo() { 
    
        string randCombo = colorArr[Random.Range(1,3)] + shapeArr[Random.Range(1,3)];

        //prints random color and shape for player
        Debug.Log(randCombo);

        if (randCombo == "RedTriangle")
        {
            //shows a random color on the left 
            GameObject randRed = red[Random.Range(1, 3)];
            Instantiate(randRed, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randTriangle = triangle[Random.Range(1, 3)];
            Instantiate(randTriangle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "RedCircle")
        {
            //shows a random color on the left 
            GameObject randRed = red[Random.Range(1, 3)];
            Instantiate(randRed, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randCircle = triangle[Random.Range(1, 3)];
            Instantiate(randCircle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "RedSquare")
        {
            //shows a random color on the left 
            GameObject randRed = red[Random.Range(1, 3)];
            Instantiate(randRed, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randSquare = triangle[Random.Range(1, 3)];
            Instantiate(randSquare, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "BlueTriangle")
        {
            //shows a random color on the left 
            GameObject randBlue = red[Random.Range(1, 3)];
            Instantiate(randBlue, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randTriangle = triangle[Random.Range(1, 3)];
            Instantiate(randTriangle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "BlueCircle")
        {
            //shows a random color on the left 
            GameObject randBlue = red[Random.Range(1, 3)];
            Instantiate(randBlue, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randCircle = triangle[Random.Range(1, 3)];
            Instantiate(randCircle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "BlueSquare")
        {
            //shows a random color on the left 
            GameObject randBlue = red[Random.Range(1, 3)];
            Instantiate(randBlue, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randSquare = triangle[Random.Range(1, 3)];
            Instantiate(randSquare, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "YellowTriangle")
        {
            //shows a random color on the left 
            GameObject randYellow = red[Random.Range(1, 3)];
            Instantiate(randYellow, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randTriangle = triangle[Random.Range(1, 3)];
            Instantiate(randTriangle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "YellowCircle")
        {
            //shows a random color on the left 
            GameObject randYellow = red[Random.Range(1, 3)];
            Instantiate(randYellow, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randCircle = triangle[Random.Range(1, 3)];
            Instantiate(randCircle, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        if (randCombo == "YellowSquare")
        {
            //shows a random color on the left 
            GameObject randYellow = red[Random.Range(1, 3)];
            Instantiate(randYellow, new Vector3(2, 0, 7.5f), Quaternion.identity);
            //shows a random shape on the right
            GameObject randSquare = triangle[Random.Range(1, 3)];
            Instantiate(randSquare, new Vector3(1.8f, 0, -5.6f), Quaternion.identity);

        }
        DetectCollisions(); 
    }

        public class DetectCollisions : MonoBehaviour{
        private void OnTriggerEnter(Collider other)
        {
            // when the player steps on a button on the floor, this checks if it is the correct combo or not 
            if (other.gameObject.tag == randCombo)
            {
                Debug.Log("Next Level!");
                RandomCombo(); 

            }
            else
            {
                Debug.Log("Game Over!");
            }
        }
    }

    
}

