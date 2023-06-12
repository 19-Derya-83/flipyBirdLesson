using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    private Rigidbody2D _rigidbody;

    [SerializeField] private float _speed;

    private bool _isDead;

    public GameManager gameManager;

    private void Awake()
    {

        _rigidbody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && _isDead == false)
        {

            MoveUp();

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Obstacle"))
        {

            Debug.Log("Obstacle");

            _isDead = true;

            gameManager.GameOver();

        }

    }

    private void MoveUp()
    {

        _rigidbody.velocity = Vector2.up * _speed;

    }

}
