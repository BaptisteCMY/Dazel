using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pik : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().EndGame(false);
        }
    }
}
