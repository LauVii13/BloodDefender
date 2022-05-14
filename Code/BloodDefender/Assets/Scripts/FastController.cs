using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastController : MonoBehaviour
{
    [SerializeField] float speed;

    bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //acertado por um tiro
        if (collision.CompareTag("Bullet"))
        {
            isAlive = false;
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //colisão com player
        if (collision.gameObject.CompareTag("Defense-Zone"))
        {
            isAlive = false;
            Destroy(gameObject, 0f);
        }
    }
}
