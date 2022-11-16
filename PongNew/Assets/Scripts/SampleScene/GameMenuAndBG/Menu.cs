using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool AccesCheck = false;
    public GameObject GameMenu;
    public static bool PlayCheck = false;
    public GameObject startText;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(AccesCheck == true)
		{
            if (Input.GetKey(KeyCode.Escape))
            {
                GameMenu.SetActive(true);
            }
            if (GameMenu.activeSelf)
            {
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }

        if(PlayCheck == true)
		{
            if (Input.GetKey(KeyCode.Space))
            {
                Time.timeScale = 1f;
                startText.SetActive(false);
                AccesCheck = true;
            }
        }

        if(PlayCheck == true)
		{
            Debug.Log("Is false");
		}
    }

    public void Resume()
	{
        GameMenu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}

    public void MainMenu()
	{
        SceneManager.LoadScene("MainMenu");
	}
}
