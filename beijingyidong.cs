using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beijingyidong : MonoBehaviour
{
    public static float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        Vector3 postion = transform.position;
        if (postion.y <= -8.52f) {
            transform.position = new Vector3(postion.x, postion.y + 2 * 8.52f, postion.z);
           }
    }
}
