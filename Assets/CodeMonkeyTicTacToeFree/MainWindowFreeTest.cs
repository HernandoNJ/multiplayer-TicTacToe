using CodeMonkey.FreeWindow;
using UnityEngine;

public class MainWindowFreeTest : MonoBehaviour
{
    public MainWindowFree mainWindowFree;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainWindowFree = new MainWindowFree();
        mainWindowFree.StartNewWindow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
