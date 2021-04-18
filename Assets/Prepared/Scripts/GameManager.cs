using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI ElementSymbol;
    public TextMeshProUGUI ElementName;
    public TextMeshProUGUI ElementColour;

    private static GameManager _Instance;
    public static GameManager Instance { get => _Instance; }

    private void Awake()
    {
        // Singleton feature
        if (_Instance != null && _Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _Instance = this;
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        ElementSymbol.SetText("");
        ElementName.SetText("");
        ElementColour.SetText("");

    }

    public void ShowSelectedElement(Element element)
    {
        ElementSymbol.SetText(element.ElementName);
        ElementName.SetText(element.Symbol);
    }
    

    public void ShowElementColour(Element element)
    {
        ElementColour.SetText(element.FlameColour);
    }


    public void HideElementText()
    {
        ElementSymbol.SetText("");
        ElementName.SetText("");
        ElementColour.SetText("");
    }
}
