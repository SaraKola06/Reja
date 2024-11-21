using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectClickHandler : MonoBehaviour
{
    int playOnce = 0;
    public GameObject options;
    public GameObject infoText;
    public GameObject Panel;
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (playOnce == 0)
        {
            infoText.SetActive(true);
            options.SetActive(true);
            Panel.SetActive(true);
            playOnce = 1;
        }
    }
}
