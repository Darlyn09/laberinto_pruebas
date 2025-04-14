using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarJuego : MonoBehaviour
{
    public void ReiniciarMapa()
    {
        // Guarda la última puntuación antes de reiniciar
        int puntuacionActual = PlayerPrefs.GetInt("Puntuacion", 0);
        PlayerPrefs.SetInt("UltimaPuntuacion", puntuacionActual);

        // Limpia la puntuación actual
        PlayerPrefs.SetInt("Puntuacion", 0);

        // Reinicia la escena
        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
