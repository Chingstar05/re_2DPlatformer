using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stagemanagement : MonoBehaviour
{

    public TextMeshProUGUI Level_1    ;
    public TextMeshProUGUI Level_2    ;
    public TextMeshProUGUI Level_3    ;
    public TextMeshProUGUI Level_4    ;
    public TextMeshProUGUI Level_5    ;

    void Start()
    {
        Level_1.text = "STAGE 1 :        " + HighScore.Load(1).ToString();
        Level_2.text = "STAGE 2 :        " + HighScore.Load(2).ToString();
        Level_3.text = "STAGE 3 :        " + HighScore.Load(3).ToString();
        Level_4.text = "STAGE 4 :        " + HighScore.Load(4).ToString();
        Level_5.text = "STAGE 5 :        " + HighScore.Load(5).ToString();

    }

    // Start is called before the first frame update
 


    // Update is called once per frame
    void Update()
    {
        
    }
}
