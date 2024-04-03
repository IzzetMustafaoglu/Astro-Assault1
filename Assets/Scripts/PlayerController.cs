using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody physic;

    public int speed;
    public float xMin, xMax, zMin, zMax;

     void Start()
    {
        physic = GetComponent<Rigidbody>();
    }

    void FixedUpdate()  
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moverHorizontal, 0, moverVertical);

        physic.velocity = movement * speed;

        Vector3 position = new Vector3(
            Mathf.Clamp(physic.position.x, xMin, xMax),
            0,
            Mathf.Clamp(physic.position.z, zMin, zMax)
        );

        physic.position = position;
    }
}
