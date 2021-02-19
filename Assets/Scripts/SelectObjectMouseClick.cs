using UnityEngine;

public class SelectObjectMouseClick : MonoBehaviour
{

    public Material SelectingMat;

    private Renderer SelectedRenderer;
    private Material DefaultMat;
    private Transform Location;
    private RaycastHit HitInfo;
    private RaycastHit TapHitInfo;

   // Update is called once per frame
    void Update()
    {

        if (Location != null)
        {
            SelectedRenderer = Location.gameObject.GetComponent<Renderer>();
            DefaultMat = Location.gameObject.GetComponent<SelectableObject>().ReturnDefaultMat();
            SelectedRenderer.material = DefaultMat;
            Location = null;
        }

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out HitInfo))
        {
            if(HitInfo.transform.tag != "Light")
            {
                if (HitInfo.transform.gameObject.GetComponent<SelectableObject>() != null)
                {
                    SelectedRenderer = HitInfo.transform.gameObject.GetComponent<Renderer>();
                    SelectedRenderer.material = SelectingMat;
                    Location = HitInfo.transform;
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out TapHitInfo))
            {
                if (TapHitInfo.transform.gameObject.GetComponent<SelectableObject>())
                {
                    if (TapHitInfo.transform.gameObject.GetComponent<SelectableObject>().ReturnHasLight())
                    {
                        TapHitInfo.transform.gameObject.GetComponent<SelectableObject>().SetLight();
                    }
                    if (TapHitInfo.transform.gameObject.GetComponent<SelecatbleObjectStory>())
                    {
                        Debug.Log(TapHitInfo.transform.gameObject.GetComponent<SelecatbleObjectStory>().ReturnStory());
                    }
                    else
                    {
                        if(TapHitInfo.transform.tag != "Light")
                        {
                            Debug.Log(ProcessString(TapHitInfo.transform.name));
                        }
                    }
                }
            }
        }
    }

    private string ProcessString(string Story)
    {
        char[] ProcessedStory = new char[Story.Length];
        for (int i = 0; i < Story.Length; i++)
        {
            //??!!What is this loop?
            if (Story[i].ToString() == "." || Story[i].ToString() == "1" || Story[i].ToString() == "2" || Story[i].ToString() == "3" || Story[i].ToString() == "4" || Story[i].ToString() == "5" || Story[i].ToString() == "6" || Story[i].ToString() == "7" || Story[i].ToString() == "8" || Story[i].ToString() == "9" || Story[i].ToString() == "(" || Story[i].ToString() == ")")
            {
                continue;
            }
            ProcessedStory[i] = Story[i];
        }
        return new string(ProcessedStory);
    }
}
