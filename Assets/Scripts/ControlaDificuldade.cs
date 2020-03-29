using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaDificuldade : MonoBehaviour
{
    [SerializeField]
    private float tempoParaDificuldadeMaxima;
    private float tempoPassado;
    public float Dificuldade { get; private set; }

    private void Update()
    {
        tempoPassado += Time.deltaTime;
        Dificuldade = tempoPassado / tempoParaDificuldadeMaxima;
        Dificuldade = Mathf.Min(1, Dificuldade);
    }

    public void ZerarDificuldade()
    {
        tempoPassado = 0;
    }
}
