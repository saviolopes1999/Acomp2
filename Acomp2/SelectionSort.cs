namespace Acomp2
{
    class SelectionSort : ISort
    {
        public void Sort(int[] E, int n)
        {
            int k, x;

            for (int i = 0; i < n; i++) //(1)
            {
                k = i;
                x = E[i];
                for (int j = i + 1; j < n; j++) //(2)
                {
                    if (E[j] < x) //(3)
                    {
                        k = j;
                        x = E[k];
                    }
                }
                E[k] = E[i];
                E[i] = x;

            }
        }

    }
}
