using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoPiscando : MonoBehaviour
{
    private Diretor diretor;
    private void Start()
    {
        diretor = FindObjectOfType<Diretor>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            diretor.IniciarJogo();
            gameObject.SetActive(false);
        }
    }
}
