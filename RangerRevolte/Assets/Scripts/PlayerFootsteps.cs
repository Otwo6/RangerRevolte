using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    [Header("Footstep Settings")]
    public float stepDistance = 5f; // Distance player must move before playing next footstep
    private float distanceMoved = 0f;
    private Vector3 lastPosition;

    [Header("Audio")]
    public AudioClip woodStep;
    public AudioClip metalStep;
    public AudioClip grassStep;
    public AudioClip defaultStep;

    [Header("Raycast Settings")]
    public float rayDistance = 1.5f;
    public LayerMask groundMask;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        float moved = Vector3.Distance(transform.position, lastPosition);
        distanceMoved += moved;

        if (distanceMoved >= stepDistance && IsMoving())
        {
            PlayFootstep();
            distanceMoved = 0f;
        }

        lastPosition = transform.position;
    }

    bool IsMoving()
    {
        // You can replace this with your own input or velocity check if needed
        return Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0;
    }

    void PlayFootstep()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, rayDistance, groundMask))
        {
            string tag = hit.collider.tag;
            switch (tag)
            {
                case "Wood":
                    SoundFXManager.instance.PlaySoundFXClip(woodStep, transform, 0.25f);
                    break;
                case "Metal":
                    SoundFXManager.instance.PlaySoundFXClip(woodStep, transform, 0.25f);
                    break;
                case "Grass":
                    SoundFXManager.instance.PlaySoundFXClip(woodStep, transform, 0.25f);
                    break;
                default:
                    SoundFXManager.instance.PlaySoundFXClip(woodStep, transform, 0.25f);
                    break;
            }
        }
        else
        {
            SoundFXManager.instance.PlaySoundFXClip(woodStep, transform, 0.25f);
            print("Help");
        }
    }
}
