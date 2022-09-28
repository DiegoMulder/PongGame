using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int Player1Score = 0;
    public int Player2Score = 0;

    public Text P1Text;
    public Text P2Text;

    public GameObject SpeedZone;
    public GameObject SpeedZone2;

    public void AddP1Score()
	{
        Player1Score++;
        P1Text.text = Player1Score.ToString();
	}
    public void AddP2Score()
	{
        Player2Score++;
        P2Text.text = Player2Score.ToString();
    }
	private void Update()
	{
		if (Player1Score > Player2Score)
		{
            SpeedZone.SetActive(true);
            SpeedZone2.SetActive(true);
		}

        if (Player2Score > Player1Score)
        {
            SpeedZone.SetActive(true);
            SpeedZone2.SetActive(true);
        }

        if (Player2Score == Player1Score)
        {
            SpeedZone.SetActive(false);
            SpeedZone2.SetActive(false);
        }
    }
}
