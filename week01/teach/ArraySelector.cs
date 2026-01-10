public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var result = new int[select.Length]; //começo com a contagem total da lista seletoraa
        var l1Idx = 0; // Uma variavel para começar sempre com idex inicial "0"
        var l2Idx = 0;/// A mesma coisa so que para segunnda lista
        for (var i = 0; i < select.Length; i++) // Inicia um loop que vai rodar de acordo com o tamanho de itens dentro do seltor
        {
            if (select[i] == 1) // Começa se o indice da lista SELECT for igual a 1 (resultado --)
                result[i] = list1[l1Idx++]; //Resultado para o indice equivale a um dos indice da lista1 e então é adicionado ++indice para a l1Idx para que se for consultar uma segunda vez sempre vai andando para o proximo na lista.
            else
                result[i] = list2[l2Idx++];//a mesma coisa caso não seja o numaro 1 e sim o numero 2
        }

        return result;
    }
}

