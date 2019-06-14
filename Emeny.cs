using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny : MonoBehaviour
{
    public int hp = 1;
    public float Speed = 2;
    public int score;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
        if (transform.position.y <= -5.3f)
        {
            Destroy(this.gameObject);
        }
    }
    public bool isDeath = false;       //是否死亡

    public Sprite[] explosionSprites;   //死亡爆炸效果的数组
    //死亡动画的计时器
    private float timer = 0;
    //死亡动画每秒播放的帧数
    public int explosionAnimationFrame = 10;

    private SpriteRenderer render;
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }
    public void BeHit()
    {
        hp -= 1;
        if (hp <= 0)
        {
            isDeath = true;
            return;
        }
    }

    private void FixedUpdate()
    {
        if (isDeath)
        {
            timer += Time.deltaTime;
            int frameIndex = (int)(timer / (1f / explosionAnimationFrame));
            if (frameIndex >= explosionSprites.Length)
            {
                Destroy(this.gameObject);
            }
            else render.sprite = explosionSprites[frameIndex];
        }
    }

}
