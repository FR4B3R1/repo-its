using CalcolatriceLib;
namespace Test_Calcolatrice

{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            //crea test per metodo somma della calcolatrice

            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato, "La somma di 2 e 3 dovrebbe essere 5.");
        }

        [TestMethod]
        public void TestSommaConZero()
        {
            //crea test per metodo somma della calcolatrice con zero
            Calcolatrice calcolatrice = new Calcolatrice();
            double risultato = calcolatrice.Somma(0, 3);
            Assert.AreEqual(3, risultato, "La somma di 0 e 3 dovrebbe essere 3.");
    }   
}
}
