using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] ParticleSystem greenEfect;
    [SerializeField] ParticleSystem purpleEfect;
    [SerializeField] ParticleSystem redEfect;


    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Green"))
        {
            Instantiate(greenEfect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("purple"))
        {
            Instantiate(purpleEfect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Rbc"))
        {
            Instantiate(redEfect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
