using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class AdminMenu : MonoBehaviour
{
    public PanelInformacion currentPanel = null;

    private List<PanelInformacion> panelHistory = new List<PanelInformacion>();

    private void Start()
    {
        SetupPanels();
    }

    private void SetupPanels()
    {
        PanelInformacion[] panels = GetComponentsInChildren<PanelInformacion>();

        foreach (PanelInformacion panel in panels)
            panel.Setup(this);

        currentPanel.Show();
       
    }

    private void Update()
    {
        if (InputBridge.Instance.RightTrigger > 0)
        {

            //GoToPrevious();
            Debug.Log("Button pressed");
        }
    }

    public void GoToPrevious()
    {
        if (panelHistory.Count == 0)
        {
                       
        }
        int lastIndex = panelHistory.Count - 1;
        setCurrent(panelHistory[lastIndex]);
        panelHistory.RemoveAt(lastIndex);
    }

    public void SetCurrentWithHistory(PanelInformacion newPanel)
    {
        panelHistory.Add(currentPanel);
        setCurrent(newPanel);
    }

    private void setCurrent(PanelInformacion newPanel)
    {
        currentPanel.Hide();

        currentPanel = newPanel;
        currentPanel.Show();
    }
} 
