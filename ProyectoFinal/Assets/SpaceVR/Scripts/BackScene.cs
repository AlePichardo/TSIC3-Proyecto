using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScene : MonoBehaviour
{
	public string SceneName;

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
    }
}