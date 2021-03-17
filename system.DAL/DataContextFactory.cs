using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace system.DAL
{
    public class DataContextFactory
    {
        /// <summary>
        /// Função utilizada para conexão com o banco de dados.
        /// Através do método GET, ele verifica se possui uma conexão com o banco, 
        /// caso contrário ele cria a conexão em seguida.
        /// 
        /// </summary>
        private static systemConnectionDataContext dataContext;
        public static systemConnectionDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new systemConnectionDataContext();
                return dataContext;
            }
        }

    }
}
