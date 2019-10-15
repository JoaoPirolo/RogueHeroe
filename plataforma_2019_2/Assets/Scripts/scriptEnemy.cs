using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemy : MonoBehaviour
{
    private bool colisao = false;
    private float movimento = -2;
    public GameObject rogue;
    public GameObject head;
    public LayerMask contato;
    public GameObject knight;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(movimento, GetComponent<Rigidbody2D>().velocity.y);
        if (colisao)
        {
            Flip();
        }
    }
    private void Flip()
    {
        movimento *= -1;
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        colisao = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Plataformas"))
        {
            colisao = true;
        }
        

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Plataformas"))
        {
            colisao = false;
        }

    }
}
    

