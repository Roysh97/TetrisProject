using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public bool ismoveDir1;

    public bool ismoveDir2;

    public bool ismoveDir3;

    public bool ismoveDir4;

    float rotationY;

    float rotationX;

    float rotationRangeY;

    float rotationRangeX;

    float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationX = Input.GetAxis("Mouse X") * speed;     
        rotationRangeX += rotationX;            // rotationX is added to the variable rotationRangeX so that makes the movement of the object to move in the x axis left and right using the mouse

        rotationY = Input.GetAxis("Mouse Y") * speed;
        rotationRangeY += rotationY;           // rotationY is added to the variable rotationRangeY so that makes the movement of the object to move in the y axis up and down using the mouse
        rotationRangeY = Mathf.Clamp(rotationRangeY, -67, 90);  // this is the range movement of the y axis up and down
        transform.rotation = Quaternion.Euler(rotationRangeY, rotationRangeX, 0);    //and all the movement affects the rotation of the object which rotates the camera as well


        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) , out hit))      //shoots like a imaginary ray from the vector z of transform positon shoots a straight ray
        {
            if (hit.collider.name == "Wall (1)")                    // and if this ray collides with a gameobject whose name is called then a boolen will become true and will make the cubes move to where the camera is at
            {
                //Debug.Log("hit occurred wall 1");
              
                ismoveDir1 = true;
                ismoveDir2 = false;
                ismoveDir3 = false;
                ismoveDir4 = false;
            }

            if (hit.collider.name == "Wall (2)")
            {
               //Debug.Log("hit occurred wall 2");
              
                ismoveDir1 = false;
                ismoveDir2 = true;
                ismoveDir3 = false;
                ismoveDir4 = false;
            }

            if (hit.collider.name == "Wall (3)")
            {
                //Debug.Log("hit occurred wall 3");
             
                ismoveDir1 = false;
                ismoveDir2 = false;
                ismoveDir3 = true;
                ismoveDir4 = false;
            }

            if (hit.collider.name == "Wall (4)")
            {
                //Debug.Log("hit occurred wall 4");
               
                ismoveDir1 = false;
                ismoveDir2 = false;
                ismoveDir3 = false;
                ismoveDir4 = true;
            }
        }
    }
}