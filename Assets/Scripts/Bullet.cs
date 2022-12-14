using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public GameObject Explosion;

    void Awake()
    {
        Destroy(gameObject, life);
    }



    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Boss"){
            GameObject explosion = (GameObject)Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if(other.gameObject.tag == "Asteroid" || other.gameObject.tag == "Wall"){
            Destroy(gameObject);
        }
        
    }



}
