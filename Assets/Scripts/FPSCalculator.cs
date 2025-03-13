using TMPro;
using UnityEngine;

public class FPSCalculator : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    private int frameCounter = 0;

    private void Awake()
    {
        InvokeRepeating("DisplayFrames",1f,1f);
    }

    private void DisplayFrames()
    {
        text.text = frameCounter.ToString();
        frameCounter = 0;
    }    
    // Update is called once per frame
    void Update()
    {
        frameCounter++;
    }
}
