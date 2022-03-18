namespace Mediator
{
    public class Program
    {
        public static void Main()
        {
           
            Mediator m = new Mediator();
            Attackers a = new Attackers(m);
            Defenders d = new Defenders(m, "shot-gun", true);
            Guards g = new Guards("tress", m, false);
            Soliders s = new Soliders("shot-gun");

            m.setComponents(a, d, g, s);

            a.move("tress");
            d.buyweapons();
            g.RuntoCastle();
            
        }
     }
}
