using UnityEngine;

public class hide : MonoBehaviour
{
    public GameObject hideObject;
    void Start(){
            hideObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void Hide()
    {
            hideObject.SetActive(false);

    }

    
}
