using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Vector3 moveAmount;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 input = new Vector3(x, 0, z);

        Vector3 velocity = speed * input;

        moveAmount = velocity * Time.deltaTime; //izjednacava razlicitr brzine kompjutera

       //transform.position = transform.position + moveAmount; isto kao i ispod

        transform.Translate(moveAmount);

        //transform.Translate(input * speed * Time.deltaTime); u ovoj liniji sve ovo gore staje u jedan red
    }

    void FixedUpdate()
    {
        transform.Translate(moveAmount);
    }
}
