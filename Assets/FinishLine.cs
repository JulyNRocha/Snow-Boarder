using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadSeconds = 2f;
    [SerializeField] ParticleSystem finishEffect;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        finishEffect.Play();
        Invoke("ReloadScene", reloadSeconds);
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
