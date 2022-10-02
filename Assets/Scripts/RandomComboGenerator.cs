using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class RandomizerGenerator : MonoBehaviour
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

    string colorOne = "Red";
    string colorTwo = "Blue";
    string colorThree = "Yellow";
    string shapeOne = "Triangle";
    string shapeTwo = "Circle";
    string shapeThree = "Square";

    string[] colorArr = new string[3] { colorOne, colorTwo, colorThree };
    string[] shapeArr = new string[3] { shapeOne, shapeTwo, shapeThree };

    GameObject[] yellow = new GameObject[3] { YellowTriangle, YellowCircle, YellowSquare };
    GameObject[] blue = new GameObject[3] { BlueTriangle, BlueCircle, BlueSquare };
    GameObject[] red = new GameObject[3] { RedTriangle, RedCircle, RedSquare };
    GameObject[] triangle = new GameObject[3] { RedTriangle, BlueTriangle, YellowTriangle };
    GameObject[] circle = new GameObject[3] { RedCircle, BlueCircle, YellowCircle };
    GameObject[] square = new GameObject[3] { RedSquare, BlueSquare, YellowSquare };

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //generates random color and shape 
        string randCombo = colorArr[rand() % 3 + 1] << shapeArr[rand() % 3 + 1];

        //prints random color and shape for player
        Debug.Log(randCombo);

        if (randCombo == "RedTriangle")
        {
            //shows a random color on the left 
            GameObject randRed = red[rand() % 3 + 1];
            Instantiate(randRed, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randTriangle = triangle[rand() % 3 + 1];
            Instantiate(randTriangle, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
        if (randCombo == "RedCircle")
        {
            //shows a random color on the left 
            GameObject randRed = red[rand() % 3 + 1];
            Instantiate(randRed, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randCircle = triangle[rand() % 3 + 1];
            Instantiate(randCircle, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
        if (randCombo == "RedSquare")
        {
            //shows a random color on the left 
            GameObject randRed = red[rand() % 3 + 1];
            Instantiate(randRed, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randSquare = triangle[rand() % 3 + 1];
            Instantiate(randSquare, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
        if (randCombo == "BlueTriangle")
        {
            //shows a random color on the left 
            GameObject randBlue = red[rand() % 3 + 1];
            Instantiate(randBlue, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randTriangle = triangle[rand() % 3 + 1];
            Instantiate(randTriangle, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
        if (randCombo == "BlueCircle")
        {
            //shows a random color on the left 
            GameObject randBlue = red[rand() % 3 + 1];
            Instantiate(randBlue, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randCircle = triangle[rand() % 3 + 1];
            Instantiate(randCircle, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
        if (randCombo == "BlueSquare")
        {
            //shows a random color on the left 
            GameObject randBlue = red[rand() % 3 + 1];
            Instantiate(randBlue, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randSquare = triangle[rand() % 3 + 1];
            Instantiate(randSquare, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
        if (randCombo == "YellowTriangle")
        {
            //shows a random color on the left 
            GameObject randYellow = red[rand() % 3 + 1];
            Instantiate(randYellow, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randTriangle = triangle[rand() % 3 + 1];
            Instantiate(randTriangle, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
        if (randCombo == "YellowCircle")
        {
            //shows a random color on the left 
            GameObject randYellow = red[rand() % 3 + 1];
            Instantiate(randYellow, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randCirclee = triangle[rand() % 3 + 1];
            Instantiate(randCircle, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
        if (randCombo == "YellowSquare")
        {
            //shows a random color on the left 
            GameObject randYellow = red[rand() % 3 + 1];
            Instantiate(randYellow, new Vector3(2, 0, 7.5), Quaternion.identity);
            //shows a random shape on the right
            GameObject randSquare = triangle[rand() % 3 + 1];
            Instantiate(randSquare, new Vector3(1.8, 0, -5.6), Quaternion.identity);

        }
    }

        public class DetectCollisions : MonoBehaviour{
        private void OnTriggerEnter(Collider other)
        {
            // when the player steps on a button on the floor, this checks if it is the correct combo or not 
            if (other.gameObject.tag == randCombo)
            {
                Debug.Log("Next Level!");
            }
            else
            {
                Debug.Log("Game Over!");
            }
        }
    }

    
}

