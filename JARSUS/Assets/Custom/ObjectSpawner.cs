using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    GameObject activeObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SpawnObject(GameObject gameObject)
    {
        GameObject newObject = (GameObject)Instantiate(gameObject, this.transform.position, Quaternion.identity);
        newObject.SetActive(true);
    }

    public void SetActiveObject(GameObject thisObject)
    {
        activeObject = thisObject;
    }

    public void DuplicateObject()
    {
        if (activeObject != null)
        {
            GameObject newObject = (GameObject)Instantiate(activeObject.GetComponent<BaseObjectReference>().BaseObject, this.transform.position, Quaternion.identity);
            newObject.SetActive(true);
        }
    }

    public void DestroyObject()
    {
        if (activeObject != null)
        {
            Destroy(activeObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
