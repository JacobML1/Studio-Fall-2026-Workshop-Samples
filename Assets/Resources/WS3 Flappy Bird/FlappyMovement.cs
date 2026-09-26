using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] public float horizSpeed;
    [SerializeField] public float flapHeight;
    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function called by Player's PlayerInput component
    public void OnFlap (InputAction.CallbackContext context)
    {
        Debug.Log("jum");
        _rb.AddForceY(flapHeight,ForceMode2D.Impulse);
    }

}
