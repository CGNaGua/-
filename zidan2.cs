using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidan2 : MonoBehaviour
{
    //子弹飞行速度
    public float Speed = 20f;

    // Update is called once per frames
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        if (transform.position.y >= 18f)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            if (!other.GetComponent<Emeny>().isDeath)
            {
                //向敌机发送消息，调用函数BeHit
                other.gameObject.SendMessage("BeHit");
                GameObject.Destroy(this.gameObject);
            }
        }
    }

}