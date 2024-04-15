namespace LeetCode;

public static class PlusOnes
{
    public static int[] PlusOne(this int[] digits)
    {
        long number = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            var contador = digits.Length - 1 - i;
            long aux = digits[i];

            if (contador <= 0)
            {
                number = number + aux + 1;
                break;
            }

            for (int j = 0; j < contador; j++)
            {
                aux *= 10;
            }
            number += aux;
        }

        ICollection<int> arrayNumber = new List<int>();
        while (number >= 0)
        {
            var item = number %10;
            arrayNumber.Add((int)item);
            number /= 10;

            if (number == default)
                break;
        }

        return arrayNumber.Reverse().ToArray();

    }
}