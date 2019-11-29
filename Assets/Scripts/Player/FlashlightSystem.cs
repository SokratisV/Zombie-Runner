using UnityEngine;

public class FlashlightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f, angleDecay = 1f, minimumAngle = 40f;
    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    private void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
    }
    public void AddLightIntensity(float intensityAmount)
    {
        myLight.intensity += intensityAmount;
    }

    private void DecreaseLightAngle()
    {
        myLight.spotAngle = Mathf.Max(myLight.spotAngle - angleDecay * Time.deltaTime, minimumAngle);
    }

    private void DecreaseLightIntensity()
    {
        myLight.intensity = Mathf.Max(myLight.intensity - lightDecay * Time.deltaTime, 0);
    }
}
