
using Constructers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructers
{
    internal class Quiz
    {

        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoord;
        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
            ingevuldeAntwoord = new QuizVraagAntwoord[aantalVragen];
        }


    }


}