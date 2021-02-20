using UnityEngine;
using UnityEngine.UI;
public class SelectObjectMouseClick : MonoBehaviour
{

    public Material SelectingMat;
    public GameObject NameTextCanvas;
    public Text NameText;

    private Renderer SelectedRenderer;
    private Material DefaultMat;
    private Transform Location;
    private RaycastHit HitInfo;
    private RaycastHit TapHitInfo;
    private OptionsManage OptionsManager;
    private SelectableObject SelectedOBJ;
    private bool NextOption = false;
    private bool LastStep = false;
    private bool CanHit = true;

    private void Start()
    {
        OptionsManager = GameObject.Find("OptionsManager").GetComponent<OptionsManage>();
    }

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
                if (HitInfo.transform.gameObject.GetComponent<SelectableObject>() != null && HitInfo.transform.gameObject.GetComponent<SelectableObject>().enabled)
                {
                    SelectedRenderer = HitInfo.transform.gameObject.GetComponent<Renderer>();
                    SelectedRenderer.material = SelectingMat;
                    Location = HitInfo.transform;
                }
            }
        }

        if (CanHit && Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out TapHitInfo))
            {
                if (TapHitInfo.transform.gameObject.GetComponent<SelectableObject>())
                {
                    if (TapHitInfo.transform.gameObject.GetComponent<SelectableObject>().ReturnHasLight())
                    {
                        TapHitInfo.transform.gameObject.GetComponent<SelectableObject>().SetLight();
                    }
                    if (TapHitInfo.transform.gameObject.GetComponent<SelecatbleObjectStory>() && TapHitInfo.transform.gameObject.GetComponent<SelecatbleObjectStory>().enabled)
                    {
                        NameTextCanvas.SetActive(false);
                        OptionsManager.GenieOptions(TapHitInfo.transform.gameObject.GetComponent<SelecatbleObjectStory>().ReturnCurrentRply(), TapHitInfo.transform.name);
                        CanHit = false;
                        NextOption = true;
                    }
                    else
                    {
                        if(TapHitInfo.transform.tag != "Light")
                        {
                            NameTextCanvas.SetActive(true);
                            NameText.text = ProcessString(TapHitInfo.transform.name);
                            SelectedOBJ = GameObject.Find(TapHitInfo.transform.name).GetComponent<SelectableObject>();
                            SelectedOBJ.enabled = false;
                        }
                    }
                }
            }
        }

        if (LastStep)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OptionsManager.LastStep();
                LastStep = false;
                CanHit = true;
            }
        }

        if (NextOption)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OptionsManager.NextOption();
                NextOption = false;
                LastStep = true;
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
