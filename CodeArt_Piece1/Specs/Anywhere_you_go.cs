using NUnit.Framework;
using CodeArt_Piece1.Poem;
using Woman = CodeArt_Piece1.Woman;

namespace Specs
{
    [TestFixture]
    public class Anywhere_you_go
    {
        [TestFixtureSetUp]
        public void Context()
        {
            Your = You = new Woman();
            My = I = new Man();
        }

        [Test]
        public void I_should_tragically_follow()
        {
            while(I.Am(Actions.Sitting) && I.Am(Actions.Next_To_You) && I.Am(Not(Sad)))
            {
                if(Your.Face.Is_Cold && Your.Face.Is_Quiet)
                {
                    I.Am(Actions.Longing);
                    I.Drink(Sadness);
                }

                You.Move(Your.Hand);
                I.Feel(Feeling_Of.Joy);
                You.Open(Your.Eyes);
                You.See(My.Face).Is_Alive();
                My.Face.Contains(Feeling_Of.Warmth, Feeling_Of.Happiness);
            }

            var We = You + I;
            while (We.Leave(This_Tomb))
            {
                We.Look_Forward_To(We);
            }

        }

        private bool Not(bool sad)
        {
            return !sad;
        }

        Woman You;
        Woman Your;
        Man I;
        Man My;
        public IPoison Sadness = new Quick_Death();
        private bool Sad;
        private object This_Tomb;
    }
}
