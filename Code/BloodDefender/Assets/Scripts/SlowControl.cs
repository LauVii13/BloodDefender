using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float d;

    Animator anim;
    int cont = 0;


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
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.CompareTag("Bullet"))
         {
            if (cont == 0)
            {
                anim.SetBool("Hit", true);
                StartCoroutine(On());
                cont++;
            }
            else
            {
                cont = 0;
                Destroy(gameObject);
            }
        }
     }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Defense-Zone"))
        {
            Destroy(gameObject);
            GameController.instance.TotalScore += d;
            GameController.instance.pain = true;
            /*if (cont == 0)
            {
                anim.SetBool("Hit", true);
                StartCoroutine(On());
                cont++;

            }
            else
            {
                Destroy(gameObject);
                GameController.instance.TotalScore -= 0.25f;
            }*/


        }

    }

    IEnumerator On()
    {

        yield return new WaitForSeconds(0.25f);
    }
}


