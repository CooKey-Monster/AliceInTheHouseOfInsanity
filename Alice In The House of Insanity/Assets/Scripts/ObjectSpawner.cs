using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] myObjects;
    private int height;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            int randomIndex = Random.Range(0,myObjects.Length);
            //first cordinate is x the middle is y and the last one is z
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10,11),height,Random.Range(-10,11));

            Instantiate(myObjects[randomIndex],randomSpawnPosition,Quaternion.identity);
        }
    }
}
