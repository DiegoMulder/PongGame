using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public GameObject BackGroundPong;

    public GameObject gameMenu;

    public GameObject playModePanel;
    public static int scoreP1 = 1;
    public static int scoreP2 = 1;
    public GameObject spaceTekst;

    public GameObject wonPanelP1;
    public GameObject wonPanelP2;
    // Start is called before the first frame update
    void Start()
    {
        scoreP1 = 1;
        scoreP2 = 1;
        spaceTekst.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            BackGroundPong.SetActive(true);
        }
	    if (Input.GetKey(KeyCode.G))
		{
            BackGroundPong.SetActive(false);
		}

        if(scoreP1 == 0)
		{
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState= CursorLockMode.None;
            wonPanelP1.SetActive(true);
            Menu.AccesCheck = false;
		}

        if (scoreP2 == 0)
        {
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            wonPanelP2.SetActive(true);
            Menu.AccesCheck = false;
        }
    }

    public void To5()
	{
        scoreP1 += 4;
        scoreP2 += 4;
        playModePanel.SetActive(false);
        spaceTekst.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Menu.PlayCheck = true;
    }

    public void To10()
    {
        scoreP1 += 9;
        scoreP2 += 9;
        playModePanel.SetActive(false);
        spaceTekst.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Menu.PlayCheck = true;
    }

    public void To15()
    {
        scoreP1 += 14;
        scoreP2 += 14;
        playModePanel.SetActive(false);
        spaceTekst.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Menu.PlayCheck = true;
    }
}
