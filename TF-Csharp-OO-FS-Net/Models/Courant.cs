using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Models
{
    internal class Courant
    {

        #region Props

        public string Numero { get; set; }

        public double Solde { get; } // Lecture Seule

        private double _ligneDeCredit;

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set
            {
                if (value >= 0)
                {
                    _ligneDeCredit = value;
                }

            }
        }

        public Personne Titulaire { get; set; }


        #endregion

        #region Methodes

        void Retrait(double montant)
        {

        }

        void Depot(double montant)
        {

        }

        #endregion

    }
}
