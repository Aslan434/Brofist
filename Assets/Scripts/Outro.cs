using UnityEngine.SceneManagement;
using UnityEngine;

public class Outro : MonoBehaviour
{

    public string NextScene;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
        }
    }
}
