using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadSeconds = 2f;
    CircleCollider2D playerHead;
    [SerializeField] ParticleSystem crashEffect;
 
    private void Start()
    {
        playerHead = GetComponent<CircleCollider2D>();
    }  
 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground" && playerHead.IsTouching(other.collider))
        {
            crashEffect.Play();
            Invoke("ReloadScene", reloadSeconds);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
