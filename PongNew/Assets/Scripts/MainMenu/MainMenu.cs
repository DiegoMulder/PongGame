using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void play()
	{
        SceneManager.LoadScene("SampleScene");
	}

    public void OnQuit()
	{
        Application.Quit();
	}
}
