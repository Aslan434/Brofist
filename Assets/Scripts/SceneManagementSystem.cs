using UnityEngine;

public class SceneManagementSystem : MonoBehaviour
{

    private GameObject[] SelecatableObjs;
    private int ID;

    public Canvas CanvasStory;

    // Start is called before the first frame update
    void Start()
    {
        SelecatableObjs = GameObject.FindGameObjectsWithTag("SelectableObj");
        foreach (GameObject SelecatableObj in SelecatableObjs)
        {
            if(SelecatableObj.GetComponent<SelecatbleObjectStory>() && SelecatableObj.GetComponent<SelecatbleObjectStory>().enabled)
            {
                ID += 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(ID == 0)
        {
            ChangeScene();
        }
    }

    public void RemoveID()
    {
        ID -= 1;
    }

    private void ChangeScene()
    {

    }
}
