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
        if (GameController.instance.comeca == false)
        {
            Destroy(gameObject);
        }
        //Movimento caso vivo
        if (isAlive)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //acertado por um tiro
        if (collision.CompareTag("Bullet"))
        {
            anim.SetTrigger("Dead");
            isAlive = false;
            Destroy(gameObject, 1f);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //colisão com player
        if (collision.gameObject.CompareTag("Player"))
        {
            isAlive = false;
            anim.SetTrigger("Dead");
            Destroy(gameObject, 1f);
        }

        //sai da tela
        if (collision.gameObject.CompareTag("BottomWall"))
        {
            Destroy(gameObject, 1f);
        }

        
    }
}
