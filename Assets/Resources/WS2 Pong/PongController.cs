using UnityEngine;
using UnityEngine.InputSystem;

public class PongController : MonoBehaviour
{

    [SerializeField]GameObject ball;
    [SerializeField] GameObject p2;
    
    [Header("Player 2 Paddle Properties")]
    public float p2Speed;
    public float p2MaxHeight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetBall();
    }

    //detect when the ball leaves the left/right side of the screen
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == ball) {
            ResetBall();
        }
    }

    //restart the game
    void ResetBall()
    {
        ball.transform.position = Vector3.zero;
        ball.GetComponent<Rigidbody2D>().linearVelocity = Random.onUnitCircle * 5;

    }

    //move p2's paddle
    private void FixedUpdate()
    {
        var d =(ball.transform.position.y - p2.transform.position.y) * p2Speed;
        p2.transform.position = new Vector3(p2.transform.position.x, Mathf.Clamp(p2.transform.position.y + d, (p2MaxHeight * -1f), p2MaxHeight), 0);
    }
}
