using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena : MonoBehaviour
{
    // Start is called before the first frame update
    public void cambioEscena(string SampleScene)
    {
        SceneManager.LoadScene(1);
    }

}
