using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject HelpPanel;
    public void GameStartButtonAction()
    {
        SceneManager.LoadScene("Level_1");


    }

    public void OpenHelpPanel()
    {
        HelpPanel.SetActive(true);
    }

    public void CoseHelpPanel()
    {
        HelpPanel.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
