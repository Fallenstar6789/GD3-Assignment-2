using UnityEngine;
using UnityEngine.UI;

public class NoteDisplay : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject button1;
    public GameObject button2;
    public GameObject image;

    [Header("Scene Object")]
    public GameObject objectToActivate;

    private void Start()
    {
        // Ensure everything starts hidden
        button1.SetActive(false);
        button2.SetActive(false);
        image.SetActive(false);
        objectToActivate.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        
            button1.SetActive(true);
        
    }

    // Assign this to Button 1 OnClick
    public void OnButton1Click()
    {
        image.SetActive(true);
        button2.SetActive(true);
    }

    // Assign this to Button 2 OnClick
    public void OnButton2Click()
    {
        objectToActivate.SetActive(false);

        image.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
    }
}


