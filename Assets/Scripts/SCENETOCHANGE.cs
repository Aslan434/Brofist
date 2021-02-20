using UnityEngine;

public class SCENETOCHANGE : MonoBehaviour
{

    public GameObject Outro;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Outro.SetActive(true);
        }
    }
}
