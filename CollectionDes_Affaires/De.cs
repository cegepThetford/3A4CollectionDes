using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDes_Affaires
{
    public class De
    {
        private int _valeur;
        private int _nbFaces;
        private static Random _aleatoire = new Random();
        public int Valeur { get { return _valeur; } set { _valeur = value; } }
        public int NbFaces { get { return _nbFaces; } set { _nbFaces = value; } }

        public De(int nbFaces = 6)
        {
            _valeur = nbFaces;
            _nbFaces = nbFaces;
        }
        public void lancer()
        {
            _valeur = 1 + _aleatoire.Next() % _nbFaces; // reste de la division entière (modulo)

            _valeur = 1 + (int)(_nbFaces * _aleatoire.NextDouble()); // transtypage explicite requis

            _valeur = 1 + _aleatoire.Next(_nbFaces);

            _valeur = _aleatoire.Next(1, _nbFaces+1);
        }
    }
}
