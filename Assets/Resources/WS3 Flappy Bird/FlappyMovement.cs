using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class FlappyMovement : MonoBehaviour
{

    //purposely inject bugs - ex.
    // using Rigidbody instead of Rigidbody2D
    // 





    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] public float flapHeight;
    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    //function called by Player's PlayerInput component
    public void OnFlap (InputAction.CallbackContext context)
    {
        _rb.AddForceY(flapHeight,ForceMode2D.Impulse);
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
