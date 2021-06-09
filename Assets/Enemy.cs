using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate ( Vector2.left * speed * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);

        }
        
    }
}
