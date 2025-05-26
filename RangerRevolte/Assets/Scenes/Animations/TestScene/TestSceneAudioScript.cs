using UnityEngine;

public class TestSceneAudioScript : MonoBehaviour
{
    [SerializeField] AudioClip talkTest;
    [SerializeField] Transform char1Trans;
    [SerializeField] Transform char2Trans;

    public void Character1Talk()
    {
        SoundFXManager.instance.PlaySoundFXClip3D(talkTest, char1Trans, 0.25f);
    } 

    public void Character2Talk()
    {
        SoundFXManager.instance.PlaySoundFXClip3D(talkTest, char2Trans, 0.25f);
    }
}
