using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipDropItem : MonoBehaviour
{

    public GameObject Cube;
    public Transform ItemParent;

    void Start()
    {
        Cube.GetComponent<Rigidbody>().isKinematic = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Drop();
        }
    }
    void Drop()
    {
        ItemParent.DetachChildren();
        Cube.transform.eulerAngles = new Vector3(Cube.transform.position.x, Cube.transform.position.y, Cube.transform.position.z);
        Cube.GetComponent<Rigidbody>().isKinematic = false;
        Cube.GetComponent<MeshCollider>().enabled = true;
    }

    void Equip()
    {
        Cube.GetComponent<Rigidbody>().isKinematic = true;

        Cube.transform.position = ItemParent.transform.position;
        Cube.transform.rotation = ItemParent.transform.rotation;

        Cube.GetComponent<MeshCollider>().enabled = false;

        Cube.transform.SetParent(ItemParent);
   }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Equip();
            }
        }
    }

}
