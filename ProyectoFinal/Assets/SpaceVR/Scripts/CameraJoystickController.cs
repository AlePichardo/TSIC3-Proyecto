using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraJoystickController : MonoBehaviour
{
	public float moveSpeed;
	private Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
    	float xInput = Input.GetAxis("Horizontal");
    	float zInput = Input.GetAxis("Vertical");

    	Vector3 dir = transform.forward * zInput + transform.right * xInput;
    	transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
