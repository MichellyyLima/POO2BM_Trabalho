using System;
using UnityEngine;

public class Jogador : Personagem
{
    
    void Start()
    {
        
    }
   
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //esquerda
        {
            transform.position -= new Vector3( getVelocidade()* Time.deltaTime, 0, 0);
        } 
        
        
        if (Input.GetKey(KeyCode.D)) //direita
        {
            transform.position += new Vector3( getVelocidade() * Time.deltaTime, 0, 0);
        } 
        

        if (Input.GetKey(KeyCode.W)) //cima
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        } 

        
        if (Input.GetKey(KeyCode.S)) //baixo
        {
            transform.position -= new Vector3(0,getVelocidade() * Time.deltaTime, 0);
        } 

        
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            int vidas = getVidas() - 1;
            seteVidas(vidas);
        }
    }
}