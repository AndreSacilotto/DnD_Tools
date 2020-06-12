using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

    public InputField G1, G2;
    public GameObject prefab;

    public Transform spawn_Right, spawn_Left;

    public Counter cnt;

    public void Iniciar()
    {
        int grupo1 = G1.text != string.Empty ? int.Parse(G1.text) : 0;
        int grupo2 = G2.text != string.Empty ? int.Parse(G2.text) : 0;

        for (int i = 0; i < grupo1; i++)
        {
            var x = Instantiate(prefab, new Vector3(spawn_Right.position.x, 0, 10 - i*2), Quaternion.identity, spawn_Right);
            x.tag = "Aliados";
            x.layer = 9;
            x.name = string.Format("Criatura G1 {0}", i);
            x.GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
            x.GetComponent<Criaturas>().cnt = cnt;
        }

        for (int i = 0; i < grupo2; i++)
        {
            var x = Instantiate(prefab, new Vector3(spawn_Left.position.x, 0, 10 - i * 2), Quaternion.identity, spawn_Left);
            x.tag = "Inimigos";
            x.layer = 10;
            x.name = string.Format("Criatura G2 {0}", i);
            x.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
            x.GetComponent<Criaturas>().cnt = cnt;
        }

        cnt.CreateList();
    }
}
