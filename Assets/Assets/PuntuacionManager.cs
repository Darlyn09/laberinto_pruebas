using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntuacionManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntajeAnterior; // Asigna en el Inspector
    private int puntuacion = 0;

    void Start()
    {
        int ultimaPuntuacion = PlayerPrefs.GetInt("UltimaPuntuacion", 0);

        // Mostrar en consola
        Debug.Log("Última puntuación: " + ultimaPuntuacion);

        // Mostrar en pantalla solo por 5 segundos
        if (textoPuntajeAnterior != null)
        {
            textoPuntajeAnterior.text = "Última puntuación: " + ultimaPuntuacion;
            textoPuntajeAnterior.gameObject.SetActive(true);
            StartCoroutine(DesactivarTextoPuntajeAnterior());
        }
        
        StartCoroutine(ImprimirPuntuacionCada3Segundos());
    }

    public void SumarPunto()
    {
        puntuacion++;
        PlayerPrefs.SetInt("Puntuacion", puntuacion);
    }

    public void GuardarPuntuacionFinal()
    {
        PlayerPrefs.SetInt("UltimaPuntuacion", puntuacion);
    }

    IEnumerator ImprimirPuntuacionCada3Segundos()
    {
        while (true)
        {
            Debug.Log("Puntuación actual: " + puntuacion);
            yield return new WaitForSeconds(3f);
        }
    }

    IEnumerator DesactivarTextoPuntajeAnterior()
    {
        yield return new WaitForSeconds(100f);
        if (textoPuntajeAnterior != null)
        {
            textoPuntajeAnterior.gameObject.SetActive(false);
        }
    }
}
