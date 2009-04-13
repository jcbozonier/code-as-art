using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodeArt_Piece1.Poem
{
    public class Man : Person
    {
        private uint _MomentsPassed = uint.MaxValue - 5;

        public Man()
        {
            A_Moment_Passes();
            Face = new Face(this);
        }

        public Face Face;

        public override void A_Moment_Passes()
        {
            _MomentsPassed++;
            var identity = _MomentsPassed / _MomentsPassed;
        }

        public bool Am(bool presentProgressive)
        {
            A_Moment_Passes();

            return presentProgressive;
        }

        public bool Am(Actions action)
        {
            if(Actions.Sitting == action)
            {
                Debug.Write("Sitting");
            }
            if(Actions.Next_To_You == action)
                Debug.Write(" next to you");
            if(Actions.Longing == action)
                Debug.Write("Longing ");
            return true;
        }

        public void Drink(IPoison sadness)
        {
            Debug.Write(", I drink my sadness");
            A_Moment_Passes();
        }

        public void Feel(Feeling_Of joy)
        {
            Debug.Write("Joy quickens my pulse,");
            A_Moment_Passes();
        }
    }
}
