using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMovement : MonoBehaviour
{
    float xHorz;
    float zHorz;
    float yHorz;

    float mouseX;
    float mouseY;

    [SerializeField]
    float mouseSens;
    float rotX;
    float rotY;

    Vector3 velocity;
    Vector3 mouseMovement;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        xHorz = Input.GetAxis("Horizontal");
        zHorz = Input.GetAxis("Vertical");
        yHorz = Input.GetAxis("QEAxis");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        rotX += mouseX * mouseSens * Time.deltaTime;
        rotY += mouseY * mouseSens * Time.deltaTime;

        velocity = new Vector3(xHorz, yHorz, zHorz);

        transform.position += velocity * Time.deltaTime;
        Quaternion localRot = Quaternion.Euler(-rotY, rotX, 0.0f);
        transform.rotation = localRot;
    }
}
