using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private Rigidbody2D _rigidbody;
    private Vector2 _moveInput;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.linearVelocity = _moveInput * _movementSpeed;
    }

    public void Move(InputAction.CallbackContext callbackContext)
    {
        _moveInput = callbackContext.ReadValue<Vector2>();
    }
}
