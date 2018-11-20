using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour {

    public int seed = 1234;
    float range = 1f;
    public GameObject[] blocks;

	void Start () {
        Random.seed = seed;
        AdjustTerrain();
    }
	
	void AdjustTerrain()
    {
        for (int i = 0; i < blocks.Length; i++)
        {
            float noise = Random.Range(-range, range);
            Vector3 pos = blocks[i].transform.position;
            blocks[i].transform.position = new Vector3(pos.x,noise,pos.z);
        }
    }
}
