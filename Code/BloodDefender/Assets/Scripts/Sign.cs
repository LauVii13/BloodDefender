using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            anim.SetBool("Hit", true);
            StartCoroutine(On());

        }
        else
        {
            anim.SetBool("Hit", false);
        }

        IEnumerator On()
        {

            yield return new WaitForSeconds(0.4f);

            anim.SetBool("Hit", false);



        }
    
    }
}
