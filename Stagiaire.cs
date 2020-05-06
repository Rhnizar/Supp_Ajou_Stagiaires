using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pa19
{
    [Serializable]
    public class Stagiaire
    {
       private string nom;
       public string Nom
       {
         get { return nom; }
         set
           { nom = value; } 
        }
       private string numero;
       public string Numero
       {
           get { return numero; }
           set {
               if (value.Length<12)
               {
                   throw new Exception("Attention le numero doit etre<12");
               }
               numero = value; }
       }
       public Stagiaire() { }
       public Stagiaire(string Numero, string Nom)
       {
          this. Nom = Nom;
          this. Numero = Numero;
       }

        
        public bool Equals(Stagiaire s,Stagiaire s1)
        {
            bool res=false;
             if(s.numero==s1.numero)
             {
                 res = true;
             }
             return res;
        }
        public override string ToString()
        {
            return "Stagiaire" + Numero.ToString() + ":" + "["+Nom+"]";
        }

    }
}
