using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{

    [SerializeField] private float _speed;

    private void Update()

    {

        if (transform.position.x < -10)
        {

            Destroy(gameObject);

        }

        PipeMove();

    }
    
    private void PipeMove()

    {

        transform.position += Vector3.left * (_speed * Time.deltaTime);

    }

}
