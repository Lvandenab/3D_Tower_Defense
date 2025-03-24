using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

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
        Vector3 pos = tile.position;
        Instantiate(ShortTowerPrefab,new Vector3(pos.x, 1, pos.z), tile.rotation, null);

        Buildable b = GetComponentInParent<Buildable>();
        b.HideMenu();
        Destroy(b);
    }
    public void LongTower()
    {
        Transform tile = GameObject.Find("BuildMenu(Clone)").transform.parent;
        Debug.Log($"Creating tower at {tile.position}, tile name {tile.name}");
        Vector3 pos = tile.position;
        Instantiate(LongTowerPrefab, new Vector3(pos.x, 1, pos.z), tile.rotation, null);
        

        Buildable b = GetComponentInParent<Buildable>();
        b.HideMenu();
        Destroy(b);
    }
}
