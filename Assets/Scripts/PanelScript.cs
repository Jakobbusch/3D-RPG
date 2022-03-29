using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{

    public GameObject Panel;
    public GameObject OptionsPanel;
    
    public Button optionsButton;

    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        optionsButton.onClick.AddListener(TaskOnClick);
        backButton.onClick.AddListener(TaskOnClickBack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void TaskOnClick()
    {
        Panel.SetActive(false);
        OptionsPanel.SetActive(true);
    }
    void TaskOnClickBack()
    {
        Panel.SetActive(true);
        OptionsPanel.SetActive(false);
    }
}
