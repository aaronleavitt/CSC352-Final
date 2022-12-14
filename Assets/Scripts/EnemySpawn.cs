using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform enemySpawnPoint;
    public GameObject enemyPrefab;
    // public Transform bossSpawnPoint;
    // public GameObject bossPrefab;
    
    void Start()
    {
        StartCoroutine(Delay(2));
    }

    
    // private void OnCollisionEnter2D(Collision2D other) {
    //     if(other.gameObject.tag == "Boss"){
    //         var boss = Instantiate(bossPrefab, bossSpawnPoint);
    //     }
    // }

    IEnumerator Delay(float time){
        yield return new WaitForSeconds(time);
            StartCoroutine(Aliens(2));
        }

    IEnumerator Aliens(float time) {
        int i = 0;
        while(i < 10){
        var enemy = Instantiate(enemyPrefab, enemySpawnPoint);
        i++;
        yield return new WaitForSeconds(time);
        }
    }

}
