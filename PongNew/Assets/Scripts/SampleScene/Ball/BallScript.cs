using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float MoveSpeed;
    private Vector3 BallDirection;
    public GameObject SpeedZone;
    public GameObject SpeedZone2;

    // Start is called before the first frame update
    void Start()
    {
        BallDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        BallDirection = BallDirection.normalized;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(BallDirection * MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D Collision)
	{
        if (Collision.gameObject.CompareTag("Wall"))
		{
            BallDirection = Vector3.Reflect(BallDirection, Collision.contacts[0].normal);
		}
        if (Collision.gameObject.CompareTag("Paddle"))
        {
            BallDirection = Vector3.Reflect(BallDirection, Collision.contacts[0].normal);
            MoveSpeed += 0.5f;
        }
        if (Collision.gameObject.CompareTag("Paddle2"))
        {
            BallDirection = Vector3.Reflect(BallDirection, Collision.contacts[0].normal);
            MoveSpeed += 0.5f;
        }
    }

    private void OnTriggerEnter2D(Collider2D Trigger)
	{
        if (Trigger.gameObject.CompareTag("Goal"))
        {
            ResetBall();
            MoveSpeed = 10;
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
        }
        if (Trigger.gameObject.CompareTag("Goal2"))
        {
            ResetBall();
            MoveSpeed = 10;
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
        }
        if (Trigger.gameObject.CompareTag("SpeedZone"))
        {
            MoveSpeed += 5;
        }
        if (Trigger.gameObject.CompareTag("SpeedZone2"))
        {
            MoveSpeed += 5;
        }
    }

    private void ResetBall()
	{
        transform.position = new Vector3(0, 0, 0);
        BallDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        BallDirection = BallDirection.normalized;
	}
}
