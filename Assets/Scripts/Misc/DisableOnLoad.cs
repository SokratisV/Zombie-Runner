using UnityEngine;

public class DisableOnLoad : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }
}
