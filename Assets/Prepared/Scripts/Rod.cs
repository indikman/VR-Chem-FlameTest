using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod : MonoBehaviour
{
    public Transform flameSpawn;

    private Element selectedElement;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("element"))
        {
            selectedElement = other.gameObject.GetComponent<Element>();

            if(selectedElement != null)
            {
                GameManager.Instance.ShowSelectedElement(selectedElement);
            }
        }else if (other.gameObject.CompareTag("flame"))
        {
            if (selectedElement != null)
            {
                GameManager.Instance.ShowElementColour(selectedElement);

                foreach(Transform child in flameSpawn)
                {
                    Destroy(child.gameObject);
                }

                GameObject flame = Instantiate(selectedElement.ParticlePrefab, flameSpawn);
                flame.transform.localPosition = Vector3.zero;
                flame.transform.localRotation = Quaternion.identity;

                selectedElement = null;

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("flame"))
        {
            GameManager.Instance.HideElementText();

            foreach (Transform child in flameSpawn)
            {
                child.GetComponent<ParticleSystem>().Stop();
            }
        }
    }

}
