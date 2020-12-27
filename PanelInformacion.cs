using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInformacion : MonoBehaviour
{
    private Canvas canvas = null;
    private AdminMenu menuManager = null;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void Setup(AdminMenu menuManager)
    {
        this.menuManager = menuManager;
        Hide();
    }

    public void Show()
    {
        canvas.enabled = true;
    }

    public void Hide()
    {
        canvas.enabled = false;
    }
}
