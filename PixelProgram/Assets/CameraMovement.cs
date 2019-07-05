using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    GameObject Selector;

    [SerializeField] float increaseDistance;
    [SerializeField] float maxDistance;
    [SerializeField] float minDistance;
    [SerializeField] float resetDistance;
    [SerializeField] Vector3 offset;
    [SerializeField] float followSpeed;

    float currentSpeed;

    #region Methods

    void Start()
    {
        Selector = GameObject.Find("Selector");
        currentSpeed = followSpeed;
    }

    private void Update() {
        if(Vector3.Distance(transform.position, Selector.transform.position) >= increaseDistance){
            currentSpeed *= 1.05f;   
        }else if (Vector3.Distance(transform.position, Selector.transform.position) <= resetDistance)
        {
            if(currentSpeed >= followSpeed * 1.05)
            currentSpeed /= 1.02f; 
        }

        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");

        if(transform.position.y <= maxDistance && transform.position.y >= minDistance)
        transform.position += new Vector3(0, -mouseScroll * 5, 0);
        offset = new Vector3(offset.x, offset.y - mouseScroll * 5, offset.z);
        increaseDistance -= mouseScroll * 5;
        resetDistance -= mouseScroll * 5; 
    }
    private void LateUpdate() {
        
        transform.position = Vector3.Lerp(transform.position, Selector.transform.position + offset, currentSpeed * Time.deltaTime);
    }

    
    #endregion
}
