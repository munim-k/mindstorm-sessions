using System;
using UnityEngine;

public class circleScript : MonoBehaviour
{
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("faizan's teacher is " + teacher + " and his room number is " + roomNumber);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("faizan's teacher is " + teacher + " and his room number is " + roomNumber);
        if (circle.transform.position.x < -9.3)
        {
            circle.transform.SetLocalPositionAndRotation(new Vector3(2,2,0), Quaternion.identity); 
        }
    }

    public void startGravity()
    {
        circle.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
    
    
}
