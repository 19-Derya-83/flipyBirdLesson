using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipe : MonoBehaviour

{

    private GameManager _gameManager;

    private void Awake()
    {

        //_gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        _gameManager = FindObjectOfType<GameManager>();

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            _gameManager.IncreaseScore();
            
            Debug.Log("Score arttýr.");

            if (_gameManager.isFinish) return;

        }

    }

}
