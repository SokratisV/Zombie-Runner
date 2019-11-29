using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f, addIntensity = 1f;
    [SerializeField] AudioClip pickupClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashlightSystem>().AddLightIntensity(addIntensity);
            other.GetComponent<AudioSource>().PlayOneShot(pickupClip);
            Destroy(gameObject);
        }
    }
}
