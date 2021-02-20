using UnityEngine;

public class Intro : MonoBehaviour
{

    public GameObject UICanvas;
    public SelectObjectMouseClick Script;


    private void Start()
    {
        Script.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UICanvas.SetActive(false);
            Script.enabled = true;
        }
    }
}
