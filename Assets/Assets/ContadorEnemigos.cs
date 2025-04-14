using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorEnemigos : MonoBehaviour
{
    public TextMeshProUGUI contadorText; // TextMeshProUGUI ahora
    private int enemigosDestruidos = 0;

    public void SumarEnemigo()
    {
        enemigosDestruidos++;
        ActualizarContador();
    }

    private void ActualizarContador()
    {
        if (contadorText != null)
        {
            contadorText.text = "Enemigos Destruidos: " + enemigosDestruidos;
        }
    }
}
