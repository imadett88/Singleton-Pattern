using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class UpService
    {
        // Constructeur privé
        private UpService() { }

        // Propriété Id avec accès privé en écriture
        public int Id { get; private set; }

        // Instance statique de la classe UpService
        private static UpService _instance;

        // Objet de verrouillage pour assurer la sécurité lors de l'accès multithread
        private static readonly object _lock = new object();

        // Méthode statique pour obtenir l'instance unique de UpService
        public static UpService GetUpService(int id)
        {
            // Vérifie si l'instance n'a pas encore été créée
            if (_instance == null)
            {
                // Verrouille l'accès pour garantir que l'instanciation est thread-safe
                lock (_lock)
                {
                    // Vérifie à nouveau pour s'assurer qu'une instance n'a pas été créée pendant que le verrou est attendu
                    if (_instance == null)
                    {
                        // Crée une nouvelle instance de UpService
                        _instance = new UpService();
                        // Initialise l'ID avec la valeur passée en argument
                        _instance.Id = id;
                    }
                }
            }
            // Retourne l'instance unique de UpService
            return _instance;
        }
    }
}
