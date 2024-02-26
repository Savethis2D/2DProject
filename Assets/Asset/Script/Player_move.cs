using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    // public bl_Joystick joy;
    public Joystick joy2;
    public Vector3 Joystick;
    public float speed = 6.0f;
    float timer;
    float waitingTime;
    private SpriteRenderer mySprite;
    Animator anim;
    Rigidbody2D rigid;
    BoxCollider2D boxcollider;
    public Vector2 touchposition = new Vector2(0, 0);

     void Awake()
    {
        rigid= GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxcollider = GetComponent<BoxCollider2D>();
        mySprite = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float x = joy2.Horizontal;
        float y = joy2.Vertical;
        Joystick = new Vector3(x, y, 0);
        Joystick.Normalize();
        if (GameManager.instance.isLive == true)
        {
            transform.position += Joystick * speed * Time.deltaTime;

            if (joy2.Horizontal > 0)
            {
                transform.localScale = new Vector3(2, 2, 2);
                mySprite.flipX = false;
            }
            if (joy2.Horizontal < 0)
            {
                transform.localScale = new Vector3(2, 2, 2);
                mySprite.flipX = true;
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
