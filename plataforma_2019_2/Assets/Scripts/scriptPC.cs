using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    private Rigidbody2D rbd;
    private Animator anim;
    private bool dir = true;
    public float velocidade;
    public GameObject pe;
    public GameObject rogue;
    public GameObject knight;
    public LayerMask contato;
    private bool chao;
    

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        velocidade = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float lado = Input.GetAxis("Horizontal");

        if (lado == 0)
            anim.SetBool("mover", false);
        else
            anim.SetBool("mover", true);

        if (lado < 0 && dir || lado > 0 && !dir)
        {
            transform.Rotate(new Vector2(0, 180));
            dir = !dir;
        }

        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {
            rbd.AddForce(new Vector2(0, 800));
        }

        rbd.velocity = new Vector2(lado * velocidade, rbd.velocity.y);

        Collider2D col;

        if (col = Physics2D.OverlapCircle(pe.transform.position,
                                                  0.3f, contato))
        {
            transform.parent = col.transform;
            chao = true;
        }

        else
        {
            transform.parent = null;
            chao = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
     {
        if(collision.gameObject.name == "knight")
        {
            Debug.Log(collision.collider.name);
            Destroy(gameObject);
        }
        else if(collision.collider.name=="head")
        {
            Debug.Log(collision.collider.name);
            Destroy(collision.collider.transform.parent.gameObject);

        }

        // Debug.Log(collision.collider.name);
    }

}