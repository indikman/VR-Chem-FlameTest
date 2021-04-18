using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{

    [SerializeField] private string elementName;
    [SerializeField] private string symbol;
    [SerializeField] private string flameColour;
    [SerializeField] private GameObject particlePrefab;


    public string Symbol { get => symbol; }
    public string ElementName { get => elementName; }
    public string FlameColour { get => flameColour; }
    public GameObject ParticlePrefab { get => particlePrefab; }
}
