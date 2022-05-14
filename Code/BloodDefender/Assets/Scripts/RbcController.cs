using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbcController : MonoBehaviour
{
    [SerializeField] float speed;
    Animator anim;
    bool isAlive = true;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            anim.SetTrigger("Dead");
            isAlive = false;
            Destroy(gameObject, 1f);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isAlive = false;
            anim.SetTrigger("Dead");
            Destroy(gameObject, 1f);
        }

        if (collision.gameObject.CompareTag("BottomWall"))
        {
            Destroy(gameObject, 1f);
        }

        
    }
}
