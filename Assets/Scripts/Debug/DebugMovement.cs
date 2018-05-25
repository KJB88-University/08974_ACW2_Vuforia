using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMovement : MonoBehaviour
{
    float xHorz;
    float zHorz;
    float yHorz;

    Vector3 velocity;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        xHorz = Input.GetAxis("Horizontal");
        zHorz = Input.GetAxis("Vertical");
        yHorz = Input.GetAxis("QEAxis");

        velocity = new Vector3(xHorz, yHorz, zHorz);

        transform.position += velocity * Time.deltaTime;
	}
}
