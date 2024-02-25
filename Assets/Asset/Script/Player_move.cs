using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public bl_Joystick joy;
    public float speed = 6.0f;

    Animator anim;
    Rigidbody2D rigid;
    BoxCollider2D boxcollider;


     void Awake()
    {
        rigid= GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxcollider = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        float x = joy.Horizontal;
        float y = joy.Vertical;
        Vector3 vec = new Vector3(x, y, 0);
        vec.Normalize();

        transform.position += vec * speed * Time.deltaTime;

        if (joy.Horizontal > 0)
        {
            anim.Play("player_walk");
            transform.localScale = new Vector3(2, 2, 2);

        }
        if (joy.Horizontal < 0)
        {
            anim.Play("player_walk");
            transform.localScale = new Vector3(-2, 2, 2);
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
