using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControl : MonoBehaviour
{
    public GUIAnimFREE[] mainMenu;
    public GUIAnimFREE[] playMenu;

    private void Start()
    {
        foreach (GUIAnimFREE ui in mainMenu)
        {
            ui.PlayInAnims(GUIAnimSystemFREE.eGUIMove.Self);
        }
    }

    public void openPlay()
    {
        foreach (GUIAnimFREE ui in playMenu)
        {
            ui.PlayInAnims(GUIAnimSystemFREE.eGUIMove.Self);
        }
    }
}
