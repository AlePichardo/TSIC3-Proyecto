using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
	public Transform orbitPivot;	//Stores the position of the object that each planet will revolve around
	public float orbitSpeed;	//Used to control how fast each planet revolves around the Sun
	public float rotationSpeed;	// How fast an object rotates around its own axis
	public float planetRadius;	//Represents a planet´s radius compared to Earth. This value will be used to set the planet´s size
	public float distFromStar;	//A planet´s distance in Astronomical Units (AU) from the Sun

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
        //Block updates the Planet´s position during each runtime frame
        this.transform.RotateAround (orbitPivot.position, Vector3.up, orbitSpeed * Time.deltaTime);
        this.transform.Rotate (Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
