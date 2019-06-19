using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    // Start is called before the first frame update

    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la escena" + nombre);
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }
}
