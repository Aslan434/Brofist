using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENETOCHANGE : MonoBehaviour
{
    public void ChangeSCENE(string Scene)
    {
        Debug.Log("dsf");
        SceneManager.LoadScene(Scene, LoadSceneMode.Additive);
    }
}
