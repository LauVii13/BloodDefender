using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float d;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.instance.comeca == false)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("purple") == gameObject)
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }


        if (collision.gameObject.CompareTag("Defense-Zone"))
        {
            Destroy(this.gameObject);
            GameController.instance.TotalScore += d;
            GameController.instance.pain = true;
        }
    }
}
