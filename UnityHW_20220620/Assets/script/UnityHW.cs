using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KuanLun
{
    public class UnityHW : MonoBehaviour
    {
        [SerializeField]
        private GameObject cube;
        [SerializeField]
        private SphereCollider sphere;
        [SerializeField]
        private GameObject caspsule;
        [SerializeField]
        Camera cam;
        [SerializeField]
        private Rigidbody rig;

        Color Randomcolor()
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color color = new Color(r, g, b);
            return color;
        }

        public float thrust = 100f;

        private void Start()
        {
            //��v���`��
            print($"��v���`�׬�: {cam.depth}");
            //�y��I���b�|
            print($"�y��I���b�|��: {sphere.radius}");
            //��v�����I���C����w���H���C��
            cam.backgroundColor = Randomcolor();
            print($"�C��: {cam.backgroundColor}");
            //���n��ؤo�אּ 3, 2, 1
            caspsule.transform.localScale = new Vector3(3, 2, 1);
        }
        private void Update()
        {
            //���ߤ���ݵ۲y�����
            transform.RotateAround(sphere.transform.position, Vector3.up, 20 * Time.deltaTime);
            //�����n�驹�W���ͱ��O
            rig.AddForce(transform.up * thrust);
        }
    }
}



