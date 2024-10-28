using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackBlock : MonoBehaviour
{
    private static Stack<StackBlock> blockStack = new Stack<StackBlock>();
    public Vector3 offsetPosition = new Vector3(2f, 0, 0); // Posição para mover o bloco


    private void Start()
    {
        // Adiciona o bloco atual à pilha
        blockStack.Push(this);

    }

    private void OnMouseDown()
    {
        // Verifica se é o bloco do topo da pilha
        if (blockStack.Count > 0 && blockStack.Peek() == this)
        {
            RemoveBlock();
        }
      
    }

    private void RemoveBlock()
    {
        // Remove o bloco do topo da pilha
        blockStack.Pop();
        MoveBlock(); // Move o bloco ao invés de destruí-lo
        Debug.Log("Bloco removido: " + name);
    }

    private void MoveBlock()
    {
        // Move o bloco para uma nova posição ao lado da pilha
        transform.position += offsetPosition; // Move o bloco
    }

    public static int GetStackCount()
    {
        return blockStack.Count;
    }
}

