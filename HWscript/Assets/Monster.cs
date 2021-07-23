
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("移動速度："), Range(0,10)]
    public float speed=3.5f;

    [Header("攻擊力："), Range(0, 500)]
    public int attack = 100;

    [Header("血量："), Range(0, 5000)]
    public float hp = 350;

    [Header("掉落道具 (遊戲物件)"), Tooltip("是否掉落道具")]
    private bool props = false;

    [Header("掉落道具機率"), Range(0, 1)]
    public int itemprobability = 1;

    [Header("掉落道具音效 (AudioClip)"), Tooltip("掉落道具時的音效")]
    public AudioClip audioClip;
    private AudioSource audioSource;
    private Rigidbody2D rig;
    private Animator ami;


    






}
