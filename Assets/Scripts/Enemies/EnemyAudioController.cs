using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EnemyAudioController : MonoBehaviour
{

    [SerializeField] AudioClip idleClip, attackClip, chaseClip, deadClip;
    AudioSource m_audioSource;
    float timer;

    private void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    public void PlayClip(ClipType type)
    {
        switch (type)
        {
            case ClipType.Attack:
                // if (timer > 0) return;
                m_audioSource.PlayOneShot(attackClip);
                timer = attackClip.length;
                break;
            case ClipType.Idle:
                if (timer > 0) return;
                m_audioSource.PlayOneShot(idleClip);
                timer = idleClip.length;
                break;
            case ClipType.Chase:
                if (timer > 0) return;
                m_audioSource.PlayOneShot(chaseClip);
                timer = chaseClip.length;
                break;
            case ClipType.Dead:
                m_audioSource.PlayOneShot(deadClip);
                timer = deadClip.length;
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
}

public enum ClipType { Attack, Idle, Chase, Dead };
