using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildable : MonoBehaviour
{
    public Material BaseMaterial;
    public Material Highlight;
    public GameObject BuildMenu;

    private GameObject Menu;
    private bool MenuShowing = false;

    public void ShowMenu()
    {
        if (!MenuShowing)
        {
            Menu = Instantiate(BuildMenu, transform);
            MenuShowing = true;
        }
    }

    public void HideMenu()
    {
        if (Menu != null)
        {
            Destroy(Menu);
        }
        MenuShowing = false;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    
    public void OnMouseOver()
    {
        gameObject.GetComponent<MeshRenderer>().material = Highlight;
    }
    public void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material = BaseMaterial;
    }
    public void OnMouseDown()
    {
        ShowMenu();
    }
}
