using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repulsion : MonoBehaviour
{
    [Header("Settings Repulsion")]
    [SerializeField] private float _repulsionForce = 10f; 
    [SerializeField] private float _acceleration = 2f; 
    [SerializeField] private bool _isIncreaseFromPlayer = true;
    [SerializeField] private float _repulsionForceFromPlayer = 20f; 
    [SerializeField] private Rigidbody2D _rb;

    private Vector2 _currentVelocity;

    private void Update()
    {
        if (_rb != null)
        {
            _currentVelocity = _rb.velocity;
        }
    }

    private void FixedUpdate()
    {
        if (_rb != null && _currentVelocity.magnitude > 0.1f)
        {
            Vector2 acceleratedVelocity = _currentVelocity.normalized * (_currentVelocity.magnitude + _acceleration * Time.fixedDeltaTime);
            _rb.velocity = acceleratedVelocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() && _isIncreaseFromPlayer)
        {
            ApplyRepulsion(collision, _repulsionForceFromPlayer);
        }
        else
        {
            ApplyRepulsion(collision);
        }

        IInteract newObject = collision.gameObject.GetComponent<IInteract>();
        newObject?.InteractWithObject();

    }

    private void ApplyRepulsion(Collision2D collision, float newForce)
    {
        if (_rb == null) return;

        Vector2 repulsionDirection = (transform.position - collision.transform.position).normalized;

        _rb.AddForce(repulsionDirection * newForce, ForceMode2D.Impulse);

    }

    private void ApplyRepulsion(Collision2D collision)
    {
        if (_rb == null) return;

        Vector2 repulsionDirection = (transform.position - collision.transform.position).normalized;

        _rb.AddForce(repulsionDirection * _repulsionForce, ForceMode2D.Impulse);

    }

    private void ApplyTriggerRepulsion(Collider2D other)
    {
        if (_rb == null) return;

        Vector2 repulsionDirection = (transform.position - other.transform.position).normalized;
        
        _rb.AddForce(repulsionDirection * _repulsionForce, ForceMode2D.Impulse);
    }

    // Метод для изменения силы отталкивания во время выполнения
    public void SetRepulsionForce(float newForce)
    {
        _repulsionForce = newForce;
    }

    // Метод для изменения ускорения во время выполнения
    public void SetAcceleration(float newAcceleration)
    {
        _acceleration = newAcceleration;
    }
}
