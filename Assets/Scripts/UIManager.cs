using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject HelpPanel;

    public GameObject leaderboardPanel;
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

    public void OpenleaderboardPanel()
    {
        leaderboardPanel.SetActive(true);
    }
    public void CoseleaderboardPanel()
    {
        leaderboardPanel.SetActive(false );
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
