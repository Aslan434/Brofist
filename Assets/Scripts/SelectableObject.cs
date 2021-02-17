using UnityEngine;

public class SelectableObject : MonoBehaviour
{

    private Material DefaultMat;

    private void Start()
    {
        DefaultMat = GetComponent<Renderer>().material;
    }

    public Material ReturnDefaultMat()
    {
        return DefaultMat;
    }
}
