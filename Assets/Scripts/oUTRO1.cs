using UnityEngine.SceneManagement;
using UnityEngine;

public class oUTRO1 : MonoBehaviour
{  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Start", LoadSceneMode.Single);
        }
    }
}
