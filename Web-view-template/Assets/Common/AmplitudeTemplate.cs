using UnityEngine;

public class AmplitudeTemplate : MonoBehaviour
{
    public string Key;
    public Amplitude Amplitude;
    private void Awake()
    {
        Initialize();
    }
    public void Initialize()
    {
        Amplitude = Amplitude.getInstance();
        Amplitude.setServerUrl("https://api2.amplitude.com");
        Amplitude.logging = true;
        Amplitude.trackSessionEvents(true);
        Amplitude.init(Key);
    }
}
