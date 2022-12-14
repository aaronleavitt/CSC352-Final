using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 10f;

    void Update() {
        float steer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Translate(steer, 0,0);
      
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
        if((other.gameObject.tag == "Enemy" || other.gameObject.tag == "Boss") && gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
        
    }



}
