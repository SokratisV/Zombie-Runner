using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] AmmoType ammoType;
    [SerializeField] int ammoAmount = 5;
    [SerializeField] AudioClip pickupClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            other.GetComponent<AudioSource>().PlayOneShot(pickupClip);
            Destroy(gameObject);
        }
    }
}
