using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENETOCHANGE : MonoBehaviour
{

    public string NextScene;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(sceneName: "Scenes/"+NextScene);
        }
    }
}
