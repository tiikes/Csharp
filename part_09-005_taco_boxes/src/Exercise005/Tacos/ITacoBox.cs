namespace Exercise005
{
    public interface ITacoBox
    {
        int TacosRemaining();
        void Eat();
    }
    public class TripleTacoBox : ITacoBox
    {
        private int tacos;

        public TripleTacoBox()
        {
            tacos = 3;
        }

        public int TacosRemaining()
        {
            return Math.Max(tacos, 0);
        }

        public void Eat()
        {
            if (tacos > 0)
            {
                tacos--;
            }
        }
    }

    public class CustomTacoBox : ITacoBox
    {
        private int tacos;

        public CustomTacoBox(int initialTacos)
        {
            tacos = Math.Max(initialTacos, 0);
        }

        public int TacosRemaining()
        {
            return Math.Max(tacos, 0);
        }

        public void Eat()
        {
            if (tacos > 0)
            {
                tacos--;
            }
        }
    }

}