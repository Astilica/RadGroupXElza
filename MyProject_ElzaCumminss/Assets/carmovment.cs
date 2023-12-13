using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmovment : MonoBehaviour
{
    // Start is called before the first frame update
    float currentspeed, drivingspeed = 3;
    float fastdriving, fdriving = 6;
    private float turningspeed = 180;
    Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        fastdriving = fdriving;
        currentspeed = drivingspeed;

    }

    // Update is called once per frame
    void Update()
    {

        // s = u t     s- distance = u (velocity) * t (time)

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += currentspeed * transform.forward * Time.deltaTime;



        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -90 * Time.deltaTime);




        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 90 * Time.deltaTime);




        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= currentspeed * transform.forward * Time.deltaTime;



        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += fastdriving * transform.forward * Time.deltaTime;


        }






























































    }

}







