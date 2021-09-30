namespace Herança
{
    public class Ponto
    {
        public int x, y;
        private int distance;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalculateDistance()
        {
            /*faz alguma coisa*/
        }

        private void CalculateDistance2()
        {
            /*Faz alguma coisa*/
        }

        public virtual void CalculateDistance3()
        {
            /*Faz alguma coisa*/
        }
    }
}