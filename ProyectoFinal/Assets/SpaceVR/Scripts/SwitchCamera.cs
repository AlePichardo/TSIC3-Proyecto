using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
	public Camera cam1, cam2;
    public KeyCode TKey;
    public bool camSwitch = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(TKey))
        {
            camSwitch = !camSwitch;
            cam1.gameObject.SetActive(camSwitch);
            cam2.gameObject.SetActive(!camSwitch);
        }
    }
}
