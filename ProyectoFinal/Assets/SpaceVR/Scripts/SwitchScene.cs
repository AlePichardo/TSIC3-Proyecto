using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
	public string SceneName;
    public string SceneName1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
        	SceneManager.LoadScene(SceneName);
        }
        if(Input.GetButton("Jump"))
        {
            SceneManager.LoadScene(SceneName1);
        }
    }
}