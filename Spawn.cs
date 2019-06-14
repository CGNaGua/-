using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawn : MonoBehaviour
{

    public GameObject enemy0Prefab;
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    public GameObject award0Prefab;
    public GameObject award1Prefab;
    //生成敌机/奖励的速率
    public float enemy0Rate = 0.5f;
    public float enemy1Rate = 2f;
    public float enemy2Rate = 5f;
    public float award0Rate = 6f;
    public float award1Rate = 10f;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("createEnemy0", 1, enemy0Rate);
        InvokeRepeating("createEnemy1", 2, enemy1Rate);
        InvokeRepeating("createEnemy2", 3, enemy2Rate);
    }

    public void createEnemy0()
    {
        float x = Random.Range(-27.2f, 26.3f);
        GameObject.Instantiate(enemy0Prefab, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
    public void createEnemy1()
    {
        float x = Random.Range(-27.2f, 26.3f);
        GameObject.Instantiate(enemy1Prefab, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
    public void createEnemy2()
    {
        float x = Random.Range(-27.2f, 26.3f);
        GameObject.Instantiate(enemy2Prefab, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
}

