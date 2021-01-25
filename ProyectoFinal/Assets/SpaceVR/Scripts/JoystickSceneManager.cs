using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoystickSceneManager : MonoBehaviour
{
	public float restartDelay = 5f;
    public Image changeSceneImage;
    public Color Colour = new Color (5.6f, 5.6f, 5.6f, 1.8f);
    public Text textBox;
    //public Text textBox1;
    //public Text textBox2;

    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            changeSceneImage.color = Colour;
            textBox.text = "¿Por qué se produce un eclipse solar?";
            Invoke("SwitchScene", restartDelay);

            //if (Input.GetButton("Fire2"))
            //{
            //    Invoke("Restart", restartDelay);
            //}

            //if (Input.GetButton("Jump"))
            //{
            //    Invoke("Exit", restartDelay);
            //}
        }
    }

    void SwitchScene()
	{
		SceneManager.LoadScene("Solar Eclipse");
	}

	//void Exit()
	//{
	//	#if UNITY_EDITOR
    //		UnityEditor.EditorApplication.isPlaying = false;
    //	#else
    //    	Application.Quit();
    //    #endif
	//}
}