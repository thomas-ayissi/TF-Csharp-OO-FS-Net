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

        public double Solde { get; set; } // Lecture Seule

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


        
        public static double operator +(double solde, Courant compte2)
        {
            
            // Equivalent du premier ternaire ci dessous

            //double valeur;

            //if (compte1.Solde > 0)
            //{
            //    valeur= compte1.Solde;
            //}
            //else
            //{
            //    valeur = 0;
            //}

            

            
            double valeur2 = compte2.Solde > 0 ? compte2.Solde : 0;
            return solde + valeur2;
        }


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
