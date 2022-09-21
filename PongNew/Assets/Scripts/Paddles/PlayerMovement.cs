using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerNumber = 1;
    public float speed = 15;
    // Update is called once per frame
    void Update()
    {
        if (playerNumber == 1)
		{
            transform.Translate(new Vector3(0, Input.GetAxis("Player1") * speed * Time.deltaTime));
        }

        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player2") * speed * Time.deltaTime));
        }
    }
}
