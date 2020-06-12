using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {

    public List<GameObject> g1;
    public List<GameObject> g2;

    //void Update()
    //{
    //    if (g1.TrueForAll(x => x == null) && g2.TrueForAll(x => x == null))           
    //}

    public void CreateList()
    {
        g1 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Aliados"));
        g2 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Inimigos"));
    }
}
