using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCreator : MonoBehaviour
{
    public GameObject [] Shape;

    public int randomNum;

    public bool iscreateOnce;

    GameObject shapeMovement;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(1, 6);    //at the start of the game a random number is role and if this number is between 1-6 then a shapecube will be created

        if (randomNum == 1)
        {
            Instantiate(Shape[0], new Vector3(transform.position.x + 3.21f, transform.position.y, transform.position.z - 0.4f), Shape[0].transform.rotation);
        }

        if (randomNum == 2)
        {
            Instantiate(Shape[1], new Vector3(transform.position.x + 3.30f, transform.position.y, transform.position.z - 3f), Shape[1].transform.rotation);
        }

        if (randomNum == 3)
        {
            Instantiate(Shape[2], new Vector3(transform.position.x + 0.47f, transform.position.y, transform.position.z), Shape[2].transform.rotation);
        }

        if (randomNum == 4)
        {
            Instantiate(Shape[3], new Vector3(transform.position.x + 3.15f, transform.position.y, transform.position.z - 4), Shape[3].transform.rotation);
        }

        if (randomNum == 5)
        {
            Instantiate(Shape[4], new Vector3(transform.position.x + 3.2f, transform.position.y, transform.position.z + 1.71f), Shape[4].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        shapeMovement = GameObject.FindWithTag("Shapes");       //in each frame of the game after the start of the game in the update a random number is role and if this number is between 1-6 then a shapecube will be created

        if (shapeMovement.GetComponent<ShapeMovement>().istouchCol == true && iscreateOnce == true)
        {
             randomNum = Random.Range(1, 6);

            if (randomNum == 1)
            {
                Instantiate(Shape[0], new Vector3(transform.position.x + 3.21f, transform.position.y, transform.position.z - 0.4f), Shape[0].transform.rotation);
            }

            if (randomNum == 2)
            {
                Instantiate(Shape[1], new Vector3(transform.position.x + 3.30f, transform.position.y, transform.position.z - 3f), Shape[1].transform.rotation);
            }

            if (randomNum == 3)
            {
                Instantiate(Shape[2], new Vector3(transform.position.x + 0.47f, transform.position.y, transform.position.z), Shape[2].transform.rotation);
            }

            if (randomNum == 4)
            {
                Instantiate(Shape[3], new Vector3(transform.position.x + 3.15f, transform.position.y, transform.position.z - 4), Shape[3].transform.rotation);
            }

            if (randomNum == 5)
            {
                Instantiate(Shape[4], new Vector3(transform.position.x + 3.2f, transform.position.y, transform.position.z + 1.71f), Shape[4].transform.rotation);
            }

            iscreateOnce = false;    //this boolen is here in order to make a shapecube to be created only one time 
        }
    }
}
