using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorController : MonoBehaviour
{

    [SerializeField] float jumpDistance;

    GameObject collisionDetection;
    public GameObject floorObject;

    Vector3 currentPos;



    #region Methods

    void Start()
    {
        collisionDetection = gameObject.transform.GetChild(4).gameObject;
        currentPos = transform.position;
    }

    private void Update()
    {
        MoveRight();
        MoveLeft();
        MoveUp();
        MoveDown();

    }


    private void MoveDown()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && CollisionObjectDetect("Down"))
        {
            transform.position = currentPos + new Vector3(0, 0, -jumpDistance);
            currentPos = transform.position;
            
        }
    } 
    private void MoveUp()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && CollisionObjectDetect("Up"))
        {
            transform.position = currentPos + new Vector3(0, 0, jumpDistance);
            currentPos = transform.position;
        }
    }
    private void MoveLeft()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && CollisionObjectDetect("Left"))
            {
                transform.position = currentPos + new Vector3(-jumpDistance, 0, 0);
                currentPos = transform.position;
            }
        }
    private void MoveRight()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && CollisionObjectDetect("Right"))
        {
            transform.position = currentPos + new Vector3(jumpDistance, 0, 0);
            currentPos = transform.position;
        }
    }

    private bool CollisionObjectDetect(string s)
    {
        MoveCollisionDetectionObject(s, "Check");

        RaycastHit hit;
        if (Physics.Raycast(collisionDetection.transform.position, -Vector3.up, out hit, 1.1f))
        {
            if (hit.transform.name.Contains("Platform"))
            {
                MoveCollisionDetectionObject(s, "Back");
                floorObject = hit.transform.gameObject;
                return true;
            }
        }
        MoveCollisionDetectionObject(s, "Back");
        return false;
    }

    private void MoveCollisionDetectionObject(string s, string d)
    {
        if(d == "Check"){
            if (s == "Right")
                collisionDetection.transform.position += new Vector3(jumpDistance, 0, 0);
            if (s == "Left")
                collisionDetection.transform.position += new Vector3(-jumpDistance, 0, 0);
            if (s == "Up")
                collisionDetection.transform.position += new Vector3(0, 0, jumpDistance);
            if (s == "Down")
                collisionDetection.transform.position += new Vector3(0, 0, -jumpDistance);
        }else if(d == "Back"){
            if (s == "Right")
                collisionDetection.transform.position += new Vector3(-jumpDistance, 0, 0);
            if (s == "Left")
                collisionDetection.transform.position += new Vector3(jumpDistance, 0, 0);
            if (s == "Up")
                collisionDetection.transform.position += new Vector3(0, 0, -jumpDistance);
            if (s == "Down")
                collisionDetection.transform.position += new Vector3(0, 0, jumpDistance);
        }
    }


    #endregion
}
