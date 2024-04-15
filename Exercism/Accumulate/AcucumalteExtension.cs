namespace Accumulate;

public static class AcucumalteExtension
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (var item in collection)
        {
            var result = func(item);
            if (result is int)
            {
                var resultInt = (int)(object)result;
                if (resultInt != default)
                    yield return (U)result;
            }
        }
    }
}

/* 
    é percorrida a colecao utilizando o foreach
    para cada item é aplicada a funcao func passada no parametro
    caso seja um inteiro default a iteracao atual é pulada
    caso tudo ocorra bem é retornado um IEnumerable yeld return (U)result
*/