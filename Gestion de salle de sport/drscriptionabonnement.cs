using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_de_salle_de_sport
{
    class drscriptionabonnement
    {
        private string description;
        private string libelle_abonnement;

        public string Description { get => description; set => description = value; }
        public string Libelle_abonnement { get => libelle_abonnement; set => libelle_abonnement = value; }
        public drscriptionabonnement() { }

        public drscriptionabonnement(string l, string d)
        {

            this.libelle_abonnement = l; this.description = d;
        }

    }
}
