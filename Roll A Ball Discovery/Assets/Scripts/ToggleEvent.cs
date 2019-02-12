using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEvent : MonoBehaviour
{
    public Object prefabOfObject;
    public Vector3 positionOfToggledObject;
    public Quaternion rotationOfToggledObject;
    private Object toggledObject;


    void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.collider.gameObject;

        if (otherObject.CompareTag("Player"))
        {
            EnterToggleEvent();
        }
    }

    private void EnterToggleEvent()
    {
        if (toggledObject == null)
        {
            Debug.Log("Create");
            toggledObject = Object.Instantiate(prefabOfObject, positionOfToggledObject, rotationOfToggledObject);
        }
        else if (toggledObject != null)
        {
            Debug.Log("Destroy");
            Destroy(toggledObject);
            toggledObject = null;
        }
    }
}
