using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CdeEscena1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnBecameInvisible()
    {
        SceneManager.LoadScene("Portada");
    }
}
