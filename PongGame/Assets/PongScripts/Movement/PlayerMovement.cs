using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;


    public string player = "Player1";
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player == "Player1")
		{
            if (Input.GetKey(KeyCode.W))
            {
                MoveUp();
            }

            if (Input.GetKey(KeyCode.S))
            {
                MoveDown();
            }
        }

        if (player == "Player2")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                MoveUp();
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                MoveDown();
            }
        }
    }

    void MoveUp()
	{
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void MoveDown()
	{
        transform.Translate(-Vector3.up * speed * Time.deltaTime);
    }
}
