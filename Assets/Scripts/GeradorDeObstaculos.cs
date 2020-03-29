using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaculo = null;
    [SerializeField]
    private float tempoFacil = 5;
    [SerializeField]
    private float tempoDificil = 0.5f;
    private float cronometro;
    private bool ativo = false;
    private ControlaDificuldade controlaDificuldade;

    private void Start()
    {
        controlaDificuldade = GameObject.FindObjectOfType<ControlaDificuldade>();
    }
    private void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro <= 0 && ativo)
        {
            Instantiate(obstaculo, transform.position, Quaternion.identity);
            cronometro = Mathf.Lerp(tempoFacil, tempoDificil, controlaDificuldade.Dificuldade);
        }
        
    }
    public void DestruirObstaculos()
    {
        Obstaculos[] obstaculos = GameObject.FindObjectsOfType<Obstaculos>();
        foreach (Obstaculos obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
    public void Ativar(bool value)
    {
        ativo = value;
    }

    
}
