using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenuScript : MonoBehaviour
{
    public GameObject ShortTowerPrefab;
    public GameObject LongTowerPrefab;
    public void Cancel()
    {
        Buildable b = GetComponentInParent < Buildable> ();
        b.HideMenu();
    }
    public void ShortTower()
    {
        Transform tile = GameObject.Find("BuildMenu(Clone)").transform.parent;
        Debug.Log($"Creating tower at {tile.position}, tile name {tile.name}");
        Instantiate(ShortTowerPrefab, tile.position, tile.rotation, null);


        Buildable b = GetComponentInParent<Buildable>();
        b.HideMenu();
    }
    public void LongTower()
    {
        Transform tile = GameObject.Find("BuildMenu(Clone)").transform.parent;
        Debug.Log($"Creating tower at {tile.position}, tile name {tile.name}");
        Instantiate(LongTowerPrefab, tile.position, tile.rotation, null);



        Buildable b = GetComponentInParent<Buildable>();
        b.HideMenu();
    }
}
