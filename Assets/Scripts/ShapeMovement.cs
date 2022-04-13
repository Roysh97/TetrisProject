using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMovement : MonoBehaviour
{
    float previousTime;

    float fallTime = 1;

    int speed = 7;

    int speedMul = 2;

    public bool istouchCol;

    public bool isStopSpeed;

    GameObject shapeManager;

    GameObject cameraRotator;

    // Start is called before the first frame update
    void Start()
    {
        shapeManager = GameObject.Find("ShapesCreator");

        cameraRotator = GameObject.Find("CameraLook");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time - previousTime);

        //Debug.Log(cameraRotator.eulerAngles.y);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -31, 31), Mathf.Clamp(transform.position.y, 11.25f, 105), Mathf.Clamp(transform.position.z, -21, 21));  //this is a boundaries for the shapecube movement 

        if (isStopSpeed == false)
        {
            if (Input.GetKey(KeyCode.Z))                                          //if long press key z then shapecubes go down faster
            {
                transform.position += new Vector3(0, -speedMul, 0);
            }

            if (Time.time - previousTime > fallTime)                          //time.time is timer of c#  in which this scene is activated and the frames are runinng if this scene is activated time.time will run in seconds to minutes and hours
                                                                              //but if time.time is bigger then one second = fallTime , than time resets to zero and that makes the shapecube fall every one second
            {
                transform.position += new Vector3(0, -speed, 0);

                previousTime = Time.time;
            }

            if (cameraRotator.GetComponent<RotateCamera>().ismoveDir1 == true)       //all of this is the movement of the shapecubes
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    transform.position += new Vector3(speed, 0, 0);
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    transform.position += new Vector3(-speed, 0, 0);
                }

                if (Input.GetKeyDown(KeyCode.W))
                {
                    transform.position += new Vector3(0, 0, -speed);
                }

                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += new Vector3(0, 0, speed);
                }
            }

            if (cameraRotator.GetComponent<RotateCamera>().ismoveDir2 == true)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    transform.position += new Vector3(0, 0, speed);
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    transform.position += new Vector3(0, 0, -speed);
                }

                if (Input.GetKeyDown(KeyCode.W))
                {
                    transform.position += new Vector3(speed, 0, 0);
                }

                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += new Vector3(-speed, 0, 0);
                }
            }

            if (cameraRotator.GetComponent<RotateCamera>().ismoveDir3 == true)
            {
              
                if (Input.GetKeyDown(KeyCode.A))
                {
                    transform.position += new Vector3(-speed, 0, 0);
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    transform.position += new Vector3(speed, 0, 0);
                }

                if (Input.GetKeyDown(KeyCode.W))
                {
                    transform.position += new Vector3(0, 0, speed);
                }

                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += new Vector3(0, 0, -speed);
                }
            }

            if (cameraRotator.GetComponent<RotateCamera>().ismoveDir4 == true)
            {
             
                if (Input.GetKeyDown(KeyCode.A))
                {
                    transform.position += new Vector3(0, 0, -speed);
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    transform.position += new Vector3(0, 0, speed);
                }

                if (Input.GetKeyDown(KeyCode.W))
                {
                    transform.position += new Vector3(-speed, 0, 0);
                }

                if (Input.GetKeyDown(KeyCode.S))
                {
                    transform.position += new Vector3(speed, 0, 0);
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            istouchCol = true;                                        //Note: every time a shapecube is created these boolens istouchCol and isStopSpeed becomes false;
                                                                      //Note: and every time a shapecube is collides with the ground or a shape cube it becomes true and stay true;
            isStopSpeed = true;

            shapeManager.GetComponent<ShapeCreator>().iscreateOnce = true;   //this code makes the game create only one shape each time the shape cube touches the ground
        }

        if (collision.gameObject.tag == "Shapes")
        {
            istouchCol = true;

            isStopSpeed = true;

            shapeManager.GetComponent<ShapeCreator>().iscreateOnce = true;  //this code makes the game create only one shape each time the shape cube touches the ground
        }
    }
}