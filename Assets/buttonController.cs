using UnityEngine;
using UnityEngine.UI;  // Required for handling UI elements like Button

public class chooseOption : MonoBehaviour
{
    public GameObject option;
    public AudioSource audioSource1; // Reference to the Audio Source

    // This method will be called when the button is clicked
    public void onButtonClick()
    {
        option.SetActive(true);
        audioSource1.Play();
    }
}
