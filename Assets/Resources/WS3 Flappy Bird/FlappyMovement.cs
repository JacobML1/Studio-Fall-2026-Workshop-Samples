using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class FlappyMovement : MonoBehaviour
{

    //purposely inject bugs - ex.
    // using Rigidbody instead of Rigidbody2D
    // 





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float flapVelocity = 5.5f;
    [SerializeField] private float maxFallSpeed = -10f;
    [SerializeField] private float maxRiseSpeed = 10f;
    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    //function called by Player's PlayerInput component
    public void OnFlap(InputAction.CallbackContext context)
    {
        if (!context.performed)
            return;

        Vector2 velocity = _rb.linearVelocity;
        velocity.y = flapVelocity;

        velocity.y = Mathf.Clamp(velocity.y, maxFallSpeed, maxRiseSpeed);

        _rb.linearVelocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("WS3 - Flappy Bird");
        }
    }

}
