using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDificultad : MonoBehaviour
{
    public GameObject panelDificultad;
    public Button facilBtn;
    public Button medioBtn;
    public Button dificilBtn;

    public static float velocidadEnemigo = 3f;
    public static int vidaEnemigo = 1;

    void Start()
    {
        panelDificultad.SetActive(true);

        facilBtn.onClick.AddListener(() => SeleccionarDificultad("facil"));
        medioBtn.onClick.AddListener(() => SeleccionarDificultad("medio"));
        dificilBtn.onClick.AddListener(() => SeleccionarDificultad("dificil"));
    }

    void SeleccionarDificultad(string dificultad)
    {
        switch (dificultad)
        {
            case "facil":
                velocidadEnemigo = 2f;
                vidaEnemigo = 1;
                break;
            case "medio":
                velocidadEnemigo = 4f;
                vidaEnemigo = 2;
                break;
            case "dificil":
                velocidadEnemigo = 6f;
                vidaEnemigo = 3;
                break;
        }

        panelDificultad.SetActive(false);
    }
}
