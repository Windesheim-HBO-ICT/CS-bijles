using System;

namespace Container
{
    public class Box
    {
        public delegate void ViewAndOrComment(GlassVase vase);
        private GlassVase _vase;

        public Box(GlassVase vase)
        {
            _vase = vase;
        }
        public Box() { }
   
        public void Insert(GlassVase vase)
        {
            if (_vase == null)
            {
                throw new InvalidOperationException("sorry maar er zit al iets in deze doos");
            }
        }

        public void LookAt()
        {
            Console.WriteLine("What a nice {0} vase", _vase.Colour);
        }


        public void LookAt(ViewAndOrComment action)
        {
            action(_vase);
        }

        // beter omdat we geen eigen delegate hoeven te declareren
        // probleem, voor de aanroepers is het nu ambigu tussen de ViewAndOrComment en de Action<Vase> functie
        // dit is omdat ze onderwater (en voor de compiler) exact hetzelfde zijn.

        // public void LookAt(Action<GlassVase> action)
        // {
        //     action(_vase);
        // }

        // andere default delegates naast action, FUNC<T1.. Tn>, Predicate<T1... Tn>
        // Func heeft de laatste T als return, en de andere als argumenten. Predicate heeft alle T params als argumenten en bool als return. Action heeft void als return

        public bool Judge(Predicate<GlassVase> Criteria)
        {
            return Criteria(_vase);
        }

        public void ChangeTheVase(Action<GlassVase> action)
        {
            action(_vase);
        }

        public Tout GetSomething<Tout>(Func<GlassVase, Tout> getter)
        {
            return getter(_vase);
        }
    }
}