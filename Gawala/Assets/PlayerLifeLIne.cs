using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifeLIne : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("EnemyBody"))
        {
            Die();
        }
    }
    void Die()
    {
        
        Invoke(nameof(ReloadLevel), 1.3f);
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
