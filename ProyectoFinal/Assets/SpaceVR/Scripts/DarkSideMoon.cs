using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSideMoon : MonoBehaviour
{
	public Transform orbitPivot;	//Stores the position of the object that each planet will revolve around
	private float planetRadius = 10.0f;	//Represents a planet´s radius compared to Earth. This value will be used to set the planet´s size
	private float distFromStar = 35.0f;	//A planet´s distance in Astronomical Units (AU) from the Sun
    private float orbitSpeed;
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Creates a random position along the orbit path
        Vector2 randomPosition = Random.insideUnitCircle;
        transform.position = new Vector3 (randomPosition.x, 0f, randomPosition.y) * distFromStar;

        //Sets the size of the GameObject to the Planet radius value
        transform.localScale = Vector3.one * planetRadius;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire2"))
        {
            orbitSpeed = 10.0f;
            rotationSpeed = 200.0f;
        }

        if(Input.GetButton("Jump"))
        {
            orbitSpeed = 40.0f;
            rotationSpeed = 0.005f;
        }

        //Block updates the Planet´s position during each runtime frame
        this.transform.RotateAround (orbitPivot.position, Vector3.up, orbitSpeed * Time.deltaTime);
        this.transform.Rotate (Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
