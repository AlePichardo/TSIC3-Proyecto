using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherMoonMovement : MonoBehaviour
{
	private Vector3 startPos;
	private Vector3 position1 = new Vector3(155.0f, -14.0f, 14.0f);
	private Vector3 position2 = new Vector3(155.0f, 14.0f, -14.0f);

	Vector3 currentTargetDestination;
	private float distanceTolerance = 0.5f;

	void Start()
	{

	}

	void Update()
	{
		if(Input.GetButton("Fire2"))
		{
			transform.position = position1;
			startPos = transform.position;
			currentTargetDestination = position2;
		}

		if(startPos == position1)
		{

			transform.position = Vector3.MoveTowards(transform.position, currentTargetDestination, 2 * Time.deltaTime);
			if(Vector3.Distance(transform.position,currentTargetDestination) <= distanceTolerance)
        	{
            	if(currentTargetDestination == position1)
            	{
                	currentTargetDestination = position2;
            	}
            	else
            	{
                	currentTargetDestination = position1;
            	}
        	}
		}
	}
}
