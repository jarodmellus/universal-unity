using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Audio;
using DG.Tweening;

[CreateAssetMenu(fileName = "New Audio Asset", menuName = "Audio/New Audio Asset")]
public class AudioClipAsset : AudioPlayable {
    public enum PlayBehavior { 
        Once, Loop, 
    }

    public bool playAtPosition;
    public bool followTarget;
    public bool playReversed;

    public AudioClip[] clips;
    public float pitch = 1f;
    public float volume = .5f;
    public AudioMixer mixer;

    public bool useVolumeCurve;
    [ShowIf("useVolumeCurve")]
    public AnimationCurve volumeCurve;
    
    public bool usePitchCurve;
    [ShowIf("usePitchCurve")]
    public AnimationCurve pitchCurve;

    public override void Play()
    {
        throw new System.NotImplementedException();
    }

    public override void Pause()
    {
        throw new System.NotImplementedException();
    }

    public override void Stop()
    {
        throw new System.NotImplementedException();
    }

    public override void Restart()
    {
        throw new System.NotImplementedException();
    }
}