using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class player : MonoBehaviour
{

    public float Speed = 100f;
    public float rate = 15f;

    public GameObject bullet;
    void Start()
    {
        OpenFire(); 
    }
    public void OpenFire() {
        InvokeRepeating("fire", 1, rate);
    }
    public void fire() {
           GameObject.Instantiate(bullet,transform.position, Quaternion.identity);
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y <= 100f)
                transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y >= -100f)
                transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x >= -100f)
                transform.Translate(new Vector3(1, 0, 0) * -Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x <= 100f)
                transform.Translate(new Vector3(1, 0, 0) * Speed * Time.deltaTime);
        }

    }
}
