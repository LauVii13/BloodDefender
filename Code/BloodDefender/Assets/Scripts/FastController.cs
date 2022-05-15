using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastController : MonoBehaviour
{
    [SerializeField] float speed;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        if (collision.gameObject.CompareTag("Defense-Zone"))
        {
            Destroy(this.gameObject);
            GameController.instance.TotalScore -= 1f;
            GameController.instance.pain = true;
        }
    }
}
