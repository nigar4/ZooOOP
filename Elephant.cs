namespace OOP
{
    public class ElephantAnimal : AbstractAnimal
    {

        public ElephantAnimal(string name, int age) : base(name, age)
        {
            Biom = BiomType.Tropic;
            Eat = "trava";
            _sound = "UUUUU";
            Name = "Lili";
        }

         
    }
}
