using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.linearVelocityX = -_movementSpeed;
    }
}
