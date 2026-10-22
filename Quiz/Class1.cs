using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public static class ScoreStore
    {

        //Propriedade pública que mantém os pontos
        public static int Points {  get; set; } = 0;

        //métodos auxiliares para clareza
        public static void Add(int pts) => Points += pts;

        public static void Reset() => Points = 0;
    }
}
