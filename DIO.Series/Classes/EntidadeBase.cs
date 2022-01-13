namespace DIO.Series {

    // Travando como default a classe de id em todos os objetos
    public abstract class EntidadeBase
    {
        private int id1;

        public int id { get => id1; protected set => id1 = value; }

    }
}