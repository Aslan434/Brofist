using UnityEngine;

public class SelectableObject : MonoBehaviour
{

    private Material DefaultMat;
    private bool LightState = false;

    public bool HasLight = false;
    public GameObject Light;

    private void Start()
    {
        if(HasLight == false)
        {
            DefaultMat = GetComponent<Renderer>().material;
        }
    }

    public Material ReturnDefaultMat()
    {
        return DefaultMat;
    }

    public bool ReturnHasLight()
    {
        return HasLight;
    }

    public void SetLight()
    {
        LightState = !LightState;
        Light.SetActive(LightState);
    }

    private void OnDisable()
    {
        var x = GameObject.Find("SceneManager");
        x.GetComponent<SceneManagementSystem>().RemoveID();
    }
}
