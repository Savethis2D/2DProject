using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public bl_Joystick joy;
    public GameObject joys;
    public Vector3 Joystick;
    public float speed = 6.0f;
    float timer;
    float waitingTime;
    private SpriteRenderer mySprite;
    Animator anim;
    Rigidbody2D rigid;
    BoxCollider2D boxcollider;
    Vector3 touchposition;

     void Awake()
    {
        rigid= GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxcollider = GetComponent<BoxCollider2D>();
        mySprite = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
            joys.SetActive(true);
            joys.transform.position = touchposition;
        }
        else
        {
            joys.SetActive(false);
        }
        float x = joy.Horizontal;
        float y = joy.Vertical;
        Joystick = new Vector3(x, y, 0);
        Joystick.Normalize();

        transform.position += Joystick * speed * Time.deltaTime;

            if (joy.Horizontal > 0)
            {
                transform.localScale = new Vector3(2, 2, 2);
                mySprite.flipX = false;
            }
            if (joy.Horizontal < 0)
            {
                transform.localScale = new Vector3(2, 2, 2);
                mySprite.flipX = true ;
            }

        
    }
    // Start is called before the first frame update
    void Start()
    {
        touchposition = Input.GetTouch(0).position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
