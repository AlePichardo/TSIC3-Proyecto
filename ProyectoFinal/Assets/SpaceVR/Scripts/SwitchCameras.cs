using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
	public Camera[] Cameras;
	//public KeyCode NextCameraKey;
	//public KeyCode PreviousCameraKey;
	private int selectedCameraIndex;

    // Start is called before the first frame update
    void Start()
    {
        DisableCameras();
        SelectCamera(0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(NextCameraKey))
        //	SelectNextCamera();
        //if (Input.GetKeyDown(PreviousCameraKey))
        //	SelectPreviousCamera();

        if (Input.GetButtonDown("Fire2"))
            SelectNextCamera();
        //if (Input.GetButtonDown("Jump"))
        //    SelectPreviousCamera();
    }

    public void SelectNextCamera()
    {
    	selectedCameraIndex = (selectedCameraIndex + 1) % Cameras.Length;
    	SelectCamera(selectedCameraIndex);
    }

    //public void SelectPreviousCamera()
    //{
    //	selectedCameraIndex = (selectedCameraIndex - 1 + Cameras.Length) % Cameras.Length;
    //	SelectCamera(selectedCameraIndex);
    //}

    public void SelectCamera(int cameraIndex)
    {
    	if(cameraIndex >= 0 && cameraIndex < Cameras.Length)
    	{
    		Cameras[selectedCameraIndex].enabled = false;
    		selectedCameraIndex = cameraIndex;
    		Cameras[selectedCameraIndex].enabled = true;
    	}
    }

    private void DisableCameras()
    {
    	for(int i = 0; i < Cameras.Length; i++)
    		Cameras[i].enabled = false;
    }
}
