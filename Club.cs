using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pa19
{
    public class Club
    {
        public List<Stagiaire> lstS=new List<Stagiaire>();
        public Club() { }
        public int NombreMembre
        {
            get { return lstS.Count; }
        }
        public int  IndiceDe(Stagiaire membre)
        {
            int i;
            for (i = 0; i < lstS.Count; i++)
            {
                if (membre.Nom == lstS[i].Nom)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Ajouter(Stagiaire membre)
        {
            
                if (IndiceDe(membre) ==-1)
                {
                    lstS.Add(membre);
                    return true;
                }
                else
            return false;
        }
        public void Supprimer(string numérolnscription)
        {
           for (int i = 0; i < lstS.Count; i++)
             {
                if (lstS[i].Numero== numérolnscription)
                  {
                   lstS.RemoveAt(i);
                  }
              else
                {
                    throw new Exception("le numero introvable ");
                }
             }
        }
       public void Supprimer(Stagiaire membre)
    {
        for (int i=0;i<lstS.Count;i++)
        {
            if (membre.Numero==lstS[i].Numero)
            {
                lstS.RemoveAt(i);
            }
            else
            {
                throw new Exception("1e stagiaire ne fait pas partie du club");
            }
        }
    }
        
        public void Enregistrer()
        {
            BinaryFormatter bf = new BinaryFormatter();
            StreamWriter sw = new StreamWriter("D:\\testTDi\\Club de lecture.bin");
            bf.Serialize(sw.BaseStream, lstS);
            sw.Close();            
            
        }
        public void Charger()
        {
            if (File.Exists("D:/testTDi/Club de lecture.bin") == false)
            {
                throw new Exception("Attention Fichier introvable !!");
             
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                StreamReader sr = new StreamReader("D:\\testTDi\\Club de lecture.bin");
                lstS = bf.Deserialize(sr.BaseStream) as List<Stagiaire>;
                sr.Close();
            }
           
        }
        public override string ToString()
        {
            string str="Club de lecture :\n-Membre("+NombreMembre+"):";
            for (int i=0;i<lstS.Count;i++)
            {
                str += "\t" + lstS[i];
            }
            return str;
        }
    }
    }

