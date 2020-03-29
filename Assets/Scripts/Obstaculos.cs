using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;
    

    private void Start()
    {
        transform.Translate(Vector3.up * Random.Range(-2f, 0.5f));
        //barreiraDeObstaculos = 
    }
    private void Update()
    {
        transform.Translate(Vector3.left * velocidade.valor * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D objectCollier)
    {
        if (objectCollier.tag == "BarreiraDeObstaculos")
        {
            Destruir();
        }
        
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
}
