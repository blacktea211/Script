
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("���ʳt�סG"), Range(0,10)]
    public float speed=3.5f;

    [Header("�����O�G"), Range(0, 500)]
    public int attack = 100;

    [Header("��q�G"), Range(0, 5000)]
    public float hp = 350;

    [Header("�����D�� (�C������)"), Tooltip("�O�_�����D��")]
    private bool props = false;

    [Header("�����D����v"), Range(0, 1)]
    public int itemprobability = 1;

    [Header("�����D�㭵�� (AudioClip)"), Tooltip("�����D��ɪ�����")]
    public AudioClip audioClip;
    private AudioSource audioSource;
    private Rigidbody2D rig;
    private Animator ami;


    






}
