int size = 5;
int[] vetor = new int[5];
int[] vetor2 = new int[5];
        
for (int i = 0; i < size; i++)
{
    vetor[i] = new Random().Next(0,100);
    Console.WriteLine(vetor[i]);
}
for (int i = 0; i < 5; i++)
{
    int menor = vetor[i];  //muda a posição e realoca na variável menor
    int guardarMenor = i;
    // no índice chamado vai somar +1 pra pegar a próx casa e guardar o valor de "i" que recebeu
    for (int j = i + 1; j < 5; j++)
    {
        if (vetor[j] < menor) //VETOR VARIAVEL está recebendo o valor de j (antes recebeu i) e vendo se o seguinte é menor
        {
            menor = vetor[j]; //variavel menor recebe o valor que esta no VETOR VARIAVEL que recebeu o valor de j
            guardarMenor = j; //outra variavel recebe o valor do j
        }
    }
    //
    vetor2[i] = menor; 
    //vetor[i] = menor;
    //vetor[guardarMenor] = vetor2[i];
}

Console.WriteLine("\nNúmeros ordenados: ");
for (int i = 0; i < 5; i++)
{
    Console.Write(vetor[i]+" ");
}