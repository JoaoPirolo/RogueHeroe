using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMovel : MonoBehaviour
{
    private Vector2 posInicial;
    private float count = 0;
    public float altura;
    public float largura;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        altura = 0;
        largura = 2;
        posInicial = transform.position;
        velocidade = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        count += (velocidade * Time.deltaTime);
        float x = Mathf.Cos(count)* largura;
        float y = Mathf.Sin(count)* altura;
        Vector2 pos = new Vector2(posInicial.x + x,posInicial.y+y);
        transform.position = pos;
        if (count >= 2 * Mathf.PI)
            count = 0;

    }
}
