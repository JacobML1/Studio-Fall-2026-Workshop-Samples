using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.InputSystem;

public class PongMovement : MonoBehaviour
{
    //Controls the paddle's movement speed
    [SerializeField] float speed;

    Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    //function called by paddle's PlayerMovement component
    public void OnMove(InputAction.CallbackContext context)
    {
        float dir = context.ReadValue<Vector2>().y;
        _rb.linearVelocityY = dir * speed;
    }

}
