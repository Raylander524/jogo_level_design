using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour
{
    public float velocidade;
    public float velocidadeMaxima;

    public float GetVelocidade()
    {
        return velocidade;
    }

    public void SetVelocidade(float valor)
    {
        if (velocidadeMaxima > 0.0f)
            if (valor <= velocidadeMaxima)
                velocidade = valor;
        else
            velocidade = valor;
    }

    public float GetVelocidadeMaxima()
    {
        return velocidadeMaxima;
    }

    public void SetVelocidadeMaxima(int valor)
    {
        velocidadeMaxima = valor;
    }
}
