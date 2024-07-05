using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc1 : MonoBehaviour
{ //variaveis
    public int saude = 5;
    public int level = 1;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        saude = saude + level;
        print("Vidas: " + saude);
    }

    // Update is called once per frame
    void Update()
    {
        //criando variavel de posição
        //Vector3- jogos 3d / vector 2- jogos 2d
        Vector3 novaPosicao = transform.position;

        //atribuir velocidade
        novaPosicao.z = novaPosicao.z + speed * Time.deltaTime;
        //nova velocidade do objeto
        transform.position = novaPosicao;
    }
}
